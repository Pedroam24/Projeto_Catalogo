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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Right, this.Top);
            form2.Show();

            Timer slideTimer = new Timer();
            slideTimer.Interval = 10;
            slideTimer.Tick += (s, ev) =>
            {
                form2.Left -= 20;
                if (form2.Left <= this.Left)
                {
                   form2.Left = this.Left;
                    slideTimer.Stop();
                    slideTimer.Dispose();
                    this.Hide(); 
                }
            };
            slideTimer.Start();
        }
    }
}
