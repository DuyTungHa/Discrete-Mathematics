using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruthValues
{
    public partial class Form1 : Form
    {
        private Validate validateTruth;
        bool pValue;
        bool qValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string p = pCombobox.SelectedItem.ToString();
            string q = qCombobox.SelectedItem.ToString();

            if (p == "True")
                pValue = true;
            else
                pValue = false;
            if (q == "True")
                qValue = true;
            else
                qValue = false;

            validateTruth = new Validate(pValue, qValue);
            checkBox1.Checked = validateTruth.ValidateAnd();
            checkBox2.Checked = validateTruth.ValidateOr();
            checkBox3.Checked = validateTruth.ValidateXor();
            checkBox4.Checked = validateTruth.ValidateImplication();
            checkBox5.Checked = validateTruth.ValidateIfandonlyif();

       
        }
    }
}
