using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //make error text invisible from last click
            errorText.Visible = false;

            if (!String.IsNullOrWhiteSpace(inputBox.Text))
            {
                int inNum = 0;

                if(int.TryParse(inputBox.Text, out inNum) == true)
                {
                    //set up answer variable and multiplier
                    double answer = 0;
                    double mult = 1.0;

                    for(double i = 0; i <= inNum; i++)
                    {
                        if (i % 2 != 0)
                        {
                            //add calculation to answer total
                            answer = answer + ((4.0 * mult) / i);
                            //change multiplier to get correct plus or minus
                            mult = mult * (- 1.0);
                        }
                    }

                    //display and show answerText
                    answerText.Visible = true;
                    answerText.Text = "=" + answer.ToString();
                }
                else
                {
                    //show errorText and hide answerText if input isn't a number
                    errorText.Visible = true;
                    answerText.Visible = false;
                }
            }
        }
    }
}
