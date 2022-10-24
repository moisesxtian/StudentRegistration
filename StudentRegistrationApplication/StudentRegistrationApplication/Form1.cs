using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        string firstn, lastn, middlen,fulln, gender, dob, program;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(.PNG*.JPEG*.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        string month,year,day;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get Full Name
            lastn =textBox1.Text;
            firstn=textBox2.Text;
            middlen=textBox3.Text;
            fulln = firstn + " " + middlen + " " + lastn;

            //Get DOB
            month = comboBox2.Text;
            day = comboBox1.Text;
            year = comboBox3.Text;
            dob = month + " " + day + ", " + year;

            //Get Program
            program = comboBox4.Text;

            //Show Info
            MessageBox.Show("Name: "+fulln+"\n"+"Gender: "+gender+"\n"+"Birthdate: "+dob+"\n"+"Program: "+program,"Regstration",MessageBoxButtons.OK);



            
        }
    }
}
