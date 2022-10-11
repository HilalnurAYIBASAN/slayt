using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slayt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int resim_sira = 1;
        string konum = "C:\\Users\\ASUS\\Desktop\\";
        int saniye = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(konum + resim_sira + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resim_sira--;
            if (resim_sira <= 0)
            {
                MessageBox.Show("Geçersiz bir işlem yaptınız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox1.Load(konum + resim_sira + ".png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            resim_sira++;
            if (resim_sira < 0)
            {
                MessageBox.Show("Geçersiz bir işlem yaptınız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox1.Load(konum + resim_sira + ".png");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye % 3 == 0)
            {
                resim_sira++;
               if (resim_sira > 5)
                {
                     resim_sira = 0;
                }
                else
                {
                    pictureBox1.Load(konum + resim_sira + ".png");
                }
            }
        }
    }
}
