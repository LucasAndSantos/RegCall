using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RegCall.Forms
{
    public partial class InfoAdicionais : Form
    {
        public InfoAdicionais()
        {
            InitializeComponent();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InfoAdicionais_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            InfoDesatualizadas info = new InfoDesatualizadas();
            info.Show();
        }
    }
}
