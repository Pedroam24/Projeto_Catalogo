using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gta_vi
{
    public partial class visualizar : Form
    {
        public visualizar()
        {
            InitializeComponent();
        }

        private void visualizar_Load(object sender, EventArgs e)
        {
            Class1 p1 = new Class1();
            label2.Text = $"Nome: {p1.nome}";
            label1.Text = $"Nome: {p1.nome}";


        }
    }
}
