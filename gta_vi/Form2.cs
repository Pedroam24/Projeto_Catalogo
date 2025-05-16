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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(this.Right, this.Top);
            form3.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                form3.Left -= 20;
                if (form3.Left <= this.Left)
                {
                    form3.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide();
                }
            };
            slideTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(this.Left - form1.Width, this.Top);
            form1.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                form1.Left += 20;
                if (form1.Left >= this.Left)
                {
                    form1.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide(); 
                }
            };
            slideTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar editar = new editar();
            editar.StartPosition = FormStartPosition.Manual;
            editar.Location = new Point(this.Right, this.Top);
            editar.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                editar.Left -= 20;
                if (editar.Left <= this.Left)
                {
                    editar.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide();
                }
            };
            slideTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visualizar visualizar = new visualizar();
            visualizar.StartPosition = FormStartPosition.Manual;
            visualizar.Location = new Point(this.Right, this.Top);
            visualizar.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                visualizar.Left -= 20;
                if (visualizar.Left <= this.Left)
                {
                    visualizar.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide();
                }
            };
            slideTimer.Start();
        }
    }
}
