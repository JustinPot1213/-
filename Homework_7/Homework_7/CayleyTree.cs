using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class CayleyTree : Form
    {

        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private Pen penColor;
        private Pen[] pens;

        public CayleyTree()
        {

            List<String> colorStrList = new List<String>();
            List<Pen> penList = new List<Pen>();
            foreach (var item in typeof(Color).GetMembers())
            {
                //只取属性且为属性中的已知Color，剔除byte属性以及一些布尔属性等（A B G R IsKnownColor Name等）
                if (item.MemberType == System.Reflection.MemberTypes.Property && Color.FromName(item.Name).IsKnownColor == true)
                {
                    Color color = Color.FromName(item.Name);
                    Pen pen = new Pen(color);
                    colorStrList.Add(color.ToString());
                    penList.Add(pen);
                }
            }
            String[] colors = colorStrList.ToArray();
            pens = penList.ToArray();
            InitializeComponent();
            this.comboBoxPen.DataSource = colors;
        }

        private void butDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panelDraw.CreateGraphics();
            else graphics.Clear(Color.White);

            int n;
            double leng;

            try
            {
                n = Int32.Parse(textBoxN.Text);
                leng = Double.Parse(textBoxLeng.Text);
                per1 = Double.Parse(textBoxPer1.Text);
                per2 = Double.Parse(textBoxPer2.Text);
                th1 = (Double.Parse(textBoxTh1.Text)) * Math.PI / 180;
                th2 = (Double.Parse(textBoxTh2.Text)) * Math.PI / 180;
                penColor =  pens[comboBoxPen.SelectedIndex];
                if (per1 < 0 || per2 < 0 || th1 < 0||th2<0) throw new FormatException();
                labelException.Text = "";
                DrawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
            }
            catch (OverflowException)
            {
                labelException.Text = "输入数字溢出";
            }
            catch (FormatException)
            {
                labelException.Text = "输入数字类型非法";
            }
        }

        void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0,double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor, (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}
