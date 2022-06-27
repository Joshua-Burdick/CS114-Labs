using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcLab
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private bool needexp = false;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable(); //For computations
            opSQRT.Text = "\u221Ax"; //Sqrt symbol
        }

        private void Compute()
        {
            try
            {
                Results.Text = dt.Compute(Results.Text, "").ToString();
            }
            catch (Exception e)
            {
                Results.Text = e.Message;
            }
        }

        private void opClear_Click(object sender, EventArgs e)
        {
            Results.Text = "";
        }

        private void opSQRT_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            else opEquals_Click(sender, e);
            try
            {
                double d = Convert.ToDouble(Results.Text);
                Results.Text = Math.Sqrt(d).ToString();
            }
            catch (Exception err)
            {
                Results.Text = err.Message;
            }
        }

        private void opEXP_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            Compute();
            Results.Text += "^";
            needexp = true;
        }

        private void computeExp()
        {
            int index = Results.Text.IndexOf("^");
            try
            {
                double first = Convert.ToDouble(Results.Text.Substring(0, index));
                double second = Convert.ToDouble(Results.Text.Substring(index + 1));
                Results.Text = Math.Pow(first, second).ToString();
            }
            catch (Exception e)
            {
                Results.Text = e.Message;
            }
            needexp = false;
        }

        private void opMod_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            Results.Text += "%";
        }

        private void opAdd_Click(object sender, EventArgs e)
        {
            if(needexp) computeExp();
            Results.Text += "+";
        }

        private void opMinus_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            Results.Text += "-";
        }

        private void opMultiply_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            Results.Text += "*";
        }

        private void opDivide_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            Results.Text += "/";
        }

        private void opEquals_Click(object sender, EventArgs e)
        {
            if (needexp) computeExp();
            else Compute();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Results.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Results.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Results.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Results.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Results.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Results.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Results.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Results.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Results.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Results.Text += "9";
        }

        private void numDec_Click(object sender, EventArgs e)
        {
            Results.Text += ".";
        }
    }
}
