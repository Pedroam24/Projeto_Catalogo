using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gta_vi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Left - form2.Width, this.Top);
            form2.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                form2.Left += 20;
                if (form2.Left >= this.Left)
                {
                    form2.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide();
                }
            };
            slideTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 p1 = new Class1();
            p1.nome = textBox1.Text;
            p1.tipo = textBox3.Text;
            p1.raca = textBox2.Text; 
            p1.nivel = int.Parse(textBox5.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
