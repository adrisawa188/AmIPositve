using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositve
{
    public partial class ifStaments : Form
    {
        double integer;
        double divideInt;
        public ifStaments()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            divideInt = integer / 7; 

            integer = Convert.ToInt32(inputBox.Text);

            if(integer > 0)
            {
                outputLabel.Text = $"{integer} is a postive number";
            }
            else
            {
                outputLabel.Text = $"{integer} is not a postive number";
            }

            if (integer % 7 == 0)
            {
                outputLabel.Text += $"\n\n{integer} is divisible by 7"; 
            }
            else
            {
                outputLabel.Text += $"\n\n{integer} is not divisble by 7"; 
            }

        }
    }
}
