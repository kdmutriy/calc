using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWork.Calc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        
       
        protected void Button8_Click(object sender, EventArgs e)
        {//+
            ViewState["first"] = TextBox1.Text;
            ViewState["arg"] = "+";
            TextBox1.Text = "";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {//=
            double first = Convert.ToDouble( ViewState["first"]);
            double second = Convert.ToDouble( TextBox1.Text);
            string arg = (string)ViewState["arg"];
            switch (arg)
            {
                case "+":TextBox1.Text = Convert.ToString(first + second);
                    break;
                case "-":
                    TextBox1.Text = Convert.ToString(first - second);
                    break;
                case "/":
                    if (second != 0)
                        TextBox1.Text = Convert.ToString(first / second);
                    else TextBox1.Text = "Div null";
                    break;
                case "*":
                    TextBox1.Text = Convert.ToString(first * second);
                    break;               
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {//-
            ViewState["first"] = TextBox1.Text;
            ViewState["arg"] = "-";
            TextBox1.Text = "";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {//*
            ViewState["first"] = TextBox1.Text;
            ViewState["arg"] = "*";
            TextBox1.Text = "";
        }

        protected void Button20_Click(object sender, EventArgs e)
        {// /
            ViewState["first"] = TextBox1.Text;
            ViewState["arg"] = "/";
            TextBox1.Text = "";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 1.ToString();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 2.ToString();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 3.ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 4.ToString();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 5.ToString();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 6.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 7.ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 8.ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 9.ToString();
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text += 0.ToString();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            ViewState["first"] = "";
            ViewState["arg"] = "";
        }
    }
    
}