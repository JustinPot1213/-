using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Homework_12;

namespace Homework_12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext orderDb;

        //构造函数把OrderContext 作为参数，Asp.net core 框架可以自动注入OrderContext对象
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(string id)
        {
            var order = buildQuery(null, null) 
            .FirstOrDefault(o => o.Id==id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // GET: api/order
        [HttpGet]
        public ActionResult<List<Order>> GetAllOrders(string itemName, string customerName)
        {
            var query = buildQuery(itemName, customerName);
            return query.ToList();
        }

        // GET: api/order/pageQuery?skip=5&&take=10  
        // GET: api/order/pageQuery?itemName=商品&&customerName=客人&&skip=5&&take=10
        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryOrder(string itemName, string customerName, int skip, int take)
        {
            var query = buildQuery(itemName, customerName).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Order> buildQuery(string itemName, string customerName)
        {
            IQueryable<Order> query = 
            orderDb.Orders.Include("Items")
                .Include("Customer");
            if (itemName != null)
            {
                query = query.Where(o => o.Items.Exists(i => i.GoodsName==itemName));
            }
            if (customerName != null)
            {
                query = query.Where(o => o.Customer.Name == customerName);
            }
            return query;
        }


        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                var todo = orderDb.Orders.Include("Items").FirstOrDefault(o => o.Id == id);
                if (todo != null)
                {
                    orderDb.Remove(todo);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}