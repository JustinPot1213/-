using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class CaculatorForm : Form
    {
        int numtemp1;
        int numtemp2;
        int r;
        int s;

        public CaculatorForm()
        {
            InitializeComponent();
        }

        private void sign_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = sign.SelectedIndex;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                numtemp1 = Int32.Parse(temp1.Text);
                numtemp2 = Int32.Parse(temp2.Text);
                Exception.Text = "";
            }
            catch (OverflowException)
            {
                Exception.Text = "输入数字溢出";
            }
            catch (FormatException)
            {
                Exception.Text = "输入数字类型非法";
            }
            if (Exception.Text == "")
            {
                switch (s)
                {
                    case 0:
                        r = numtemp1 + numtemp2;
                        break;
                    case 1:
                        r = numtemp1 - numtemp2;
                        break;
                    case 2:
                        r = numtemp1 * numtemp2;
                        break;
                    case 3:
                        if (numtemp2 != 0) r = numtemp1 / numtemp2;
                        else Exception.Text = "被除数为零";
                        break;
                }
            }
            if (Exception.Text == "") result.Text = r.ToString();
        }

        private void CaculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
