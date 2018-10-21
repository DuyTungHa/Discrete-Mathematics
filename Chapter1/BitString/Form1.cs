using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitString
{
    public partial class Form1 : Form
    {
        List<int> a;
        List<int> b;
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            aLabel.Visible = false;
            bLabel.Visible = false;
            aTextBox.Visible = false;
            bTextBox.Visible = false;
            a0Button.Visible = false;
            a1Button.Visible = false;
            b0Button.Visible = false;
            b1Button.Visible = false;
            calculateButton.Visible = false;

            andLabel.Text = String.Empty;
            orLabel.Text = String.Empty;
            xorLabel.Text = String.Empty;

            aTextBox.ReadOnly = true;
            bTextBox.ReadOnly = true;

            a = new List<int>();
            b = new List<int>();
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            //Start the box
            aLabel.Visible = true;
            bLabel.Visible = true;
            aTextBox.Visible = true;
            bTextBox.Visible = true;
            a0Button.Visible = true;
            a1Button.Visible = true;
            b0Button.Visible = true;
            b1Button.Visible = true;
            aTextBox.MaxLength = (int)characterNumericUpDown.Value;
            bTextBox.MaxLength = (int)characterNumericUpDown.Value;

            //New calculation
            a.Clear();
            b.Clear();
            aTextBox.Text = String.Empty;
            bTextBox.Text = String.Empty;


            //Incase someone change the fixed number of Characters again
            calculateButton.Visible = false;
            CheckMaxLength();
        }

        private void a0Button_Click(object sender, EventArgs e)
        {
            aTextBox.Text += "0";
            a.Add(0);
            CheckMaxLength();
        }

        private void a1Button_Click(object sender, EventArgs e)
        {
            aTextBox.Text += "1";
            a.Add(1);
            CheckMaxLength();
        }

        private void b0Button_Click(object sender, EventArgs e)
        {
            bTextBox.Text += "0";
            b.Add(0);
            CheckMaxLength();
        }

        private void b1Button_Click(object sender, EventArgs e)
        {
            bTextBox.Text += "1";
            b.Add(1);
            CheckMaxLength();
        }

        private void CheckMaxLength()
        {
            if (aTextBox.TextLength == aTextBox.MaxLength)
            {
                a1Button.Visible = false;
                a0Button.Visible = false;
            }

            if (bTextBox.TextLength == bTextBox.MaxLength)
            {
                b1Button.Visible = false;
                b0Button.Visible = false;
            }

            if (aTextBox.TextLength == aTextBox.MaxLength && bTextBox.TextLength == bTextBox.MaxLength)
            {
                calculateButton.Visible = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Start calculation
            orLabel.Text = String.Empty;
            xorLabel.Text = String.Empty;
            andLabel.Text = String.Empty;

            //Calculation Algorithm
            for (int i = 0; i < a.Count; i++)
            {
               if (a[i] == 1 && b[i] ==1)
                {
                    andLabel.Text += "1";
                    orLabel.Text += "1";
                    xorLabel.Text += "0";
                }

               if ((a[i] ==1 && b[i] == 0)|| (a[i]==0 && b[i] ==1))
                {
                    andLabel.Text += "0";
                    orLabel.Text += "1";
                    xorLabel.Text += "1";
                }

               if (a[i]==0 && b[i]==0)
                {
                    andLabel.Text += "0";
                    orLabel.Text += "0";
                    xorLabel.Text += "0";
                }
            }
        }
    }
}
