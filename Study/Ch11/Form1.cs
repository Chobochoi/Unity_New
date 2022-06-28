using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1","3",MessageBoxButtons.YesNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3개가짐","4",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
        }
       

        private void bt5_Click(object sender, EventArgs e)
        {
            string uid = xtxUid.Text;
            rs1.Text = "결과 :" +uid;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            string uid = textBox2.Text;
            rs2.Text = "결과 :" +uid;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            string uid = xtxHP.Text;
            rs3.Text = "결과 :" +uid;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = {chpFruit1, chpFruit2, chpFruit3,chpFruit4,chpFruit5};
            List<string> fruits = new List<string>();

            foreach(CheckBox chb in chbFruits)
            {
                if (chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbResultFruit.Text = "선택한 과일 : " +String.Join(", ", fruits);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "결과 : 남성";
            }
            else
            {
                lbResultGender.Text = "결과 : 여자";
            }


        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (rdGrade1.Checked)
            {
                lbResultGrade.Text = "결과 : 1학년";
            }
           else if (rdGrade2.Checked)
            {
               lbResultGrade.Text = "결과 : 2학년";
            }
            else if (rdGrade3.Checked)
            {
                lbResultGrade.Text = "결과 : 3학년";
            }
            else if (rdGrade4.Checked)
            {
                lbResultGrade.Text = "결과 : 4학년";
            }

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
