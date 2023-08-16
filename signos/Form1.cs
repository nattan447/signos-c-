using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signos
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string inputDate = maskedTextBox1.Text;
            string format = "dd/MM/yyyy";
            if (DateTime.TryParseExact(inputDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                if (data.Day >=21 && data.Month==3 || data.Day<=21 && data.Month==4 )
                {
                    pictureBox1.Image = Properties.Resources.aries;
                }
                else if (data.Day >= 21 && data.Month == 4 || data.Day <= 20 && data.Month == 5)
                {
                    pictureBox1.Image = Properties.Resources.touro;
                }
                else if (data.Day >= 21 && data.Month == 5 || data.Day <= 20 && data.Month == 6)
                {
                    pictureBox1.Image = Properties.Resources.gemeos;
                }
                else if (data.Day >= 21 && data.Month == 6 || data.Day <= 21 && data.Month == 7)
                {
                    pictureBox1.Image = Properties.Resources.cancer;
                }
                else if (data.Day >= 22 && data.Month == 7 || data.Day <= 22 && data.Month == 8)
                {
                    pictureBox1.Image = Properties.Resources.leao;
                }
                else if (data.Day >= 23 && data.Month == 8 || data.Day <= 22 && data.Month == 9)
                {
                    pictureBox1.Image = Properties.Resources.virgem;
                }
                else if (data.Day >= 23 && data.Month == 9 || data.Day <= 22 && data.Month == 10)
                {
                    pictureBox1.Image = Properties.Resources.libra;
                }
                else if (data.Day >= 23 && data.Month == 10 || data.Day <= 21 && data.Month == 11)
                {
                    pictureBox1.Image = Properties.Resources.escorpiao;
                }
                else if (data.Day >= 22 && data.Month == 11 || data.Day <= 21 && data.Month == 12)
                {
                    pictureBox1.Image = Properties.Resources.sagitario;
                }
                else if (data.Day >= 22 && data.Month == 12 || data.Day <= 20 && data.Month == 1)
                {
                    pictureBox1.Image = Properties.Resources.capricornio;
                }
                else if (data.Day >= 21 && data.Month == 1 || data.Day <=19 && data.Month == 2)
                {
                    pictureBox1.Image = Properties.Resources.aquario;
                }
                else if (data.Day >= 20 && data.Month == 2 || data.Day <= 20 && data.Month == 3)
                {
                    pictureBox1.Image = Properties.Resources.peixes;
                }
            }
            else
            {
                MessageBox.Show("valor invalido");
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
