using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        double l_val, r_val;
        int index;
        char op;
        public Form1()
        {
            l_val = 0;
            r_val = 0;
            index = 0;
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void append1_Click(object sender, EventArgs e)
        {
            cell.Text += "1";
        }

        private void append2_Click(object sender, EventArgs e)
        {
            cell.Text += "2";
        }

        private void append3_Click(object sender, EventArgs e)
        {
            cell.Text += "3";
        }

        private void append4_Click(object sender, EventArgs e)
        {
            cell.Text += "4";
        }

        private void append5_Click(object sender, EventArgs e)
        {
            cell.Text += "5"; 
        }

        private void append6_Click(object sender, EventArgs e)
        {
            cell.Text += "6"; 
        }

        private void append7_Click(object sender, EventArgs e)
        {
            cell.Text += "7"; 
        }

        private void append8_Click(object sender, EventArgs e)
        {
            cell.Text += "8";
        }

        private void append9_Click(object sender, EventArgs e)
        {
            cell.Text += "9"; 
        }

        private void append0_Click(object sender, EventArgs e)
        {
            cell.Text += "0"; 
        }

        private void appenddot_Click(object sender, EventArgs e)
        {
            cell.Text += "."; 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (index == 0)
                l_val = Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
            else
                l_val -=Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
           
            index = cell.Text.Length+1;
            cell.Text += "-";
            op = '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (index == 0)
                l_val = Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
            else
            {
               
                l_val *= Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
                
            }
          
            index = cell.Text.Length + 1;
            cell.Text += "*";
            op = '*';
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (index == 0)
                l_val = Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
            else
            {

                l_val /= Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));

            }
           
            index = cell.Text.Length + 1;
            cell.Text += "/";
            op = '/';
        }

        private void total_Click(object sender, EventArgs e)
        {
            r_val = Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
            
            if(op=='+')
            {
                cell.Text = (l_val + r_val).ToString();
            }
            else
                if(op=='-')
            {
                cell.Text = (l_val - r_val).ToString();
            }
            else
                if(op=='*')
            {
                cell.Text = (l_val * r_val).ToString();
            }
            else
                if(op=='/')
            {
                cell.Text = (l_val / r_val).ToString();
            }
            index = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            l_val += Double.Parse(cell.Text.Substring(index, cell.Text.Length - index));
            index = cell.Text.Length+1;
            cell.Text += "+";
            
            op = '+';
        }
    }
}
