using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;

namespace RegCall
{
    public partial class UC_Inicio : UserControl
    {
        private object mail;

        public UC_Inicio()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label3.Text);
        }
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("Mailto:" + label3.Text);
        }
    }
}
