using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegCall
{
    public partial class CheckLists : Form
    {
        public CheckLists()
        {

            InitializeComponent();
        }
        private void CheckLists_Load(object sender, EventArgs e)
        {
            UC_CKList_Field uc_field = new UC_CKList_Field();
            AdicionarControleAoPanel(uc_field);            
        }
        private void AdicionarControleAoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnl_fundo.Controls.Clear();
            pnl_fundo.Controls.Add(c);
        }
        private void btn_field_Click(object sender, EventArgs e)
        {
            UC_CKList_Field uc_field = new UC_CKList_Field();
            AdicionarControleAoPanel(uc_field);
        }
        private void btn_telefonia_Click(object sender, EventArgs e)
        {
            UC_CKList_Telefonia uc_telefonia = new UC_CKList_Telefonia();            
            AdicionarControleAoPanel(uc_telefonia);
        }       
    }
}
