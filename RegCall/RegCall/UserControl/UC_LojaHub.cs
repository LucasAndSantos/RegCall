using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegCall.Forms;
using System.Data.OleDb;

namespace RegCall
{
    public partial class UC_LojaHub : UserControl
    {
        public UC_LojaHub()
        {
            InitializeComponent();
        }       
        private void btn_maisInfo_Click(object sender, EventArgs e)
        {
            InfoAdicionais adic = new InfoAdicionais();
            adic.Show();
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
//conexaoDb
                String stringConex = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lucas\Desktop\DataBaseDPA.mdb";
                OleDbConnection conexaoDb = new OleDbConnection(stringConex);
                conexaoDb.Open();

                String strSql = "SELECT * FROM lojaHubInfo WHERE CDLOJA LIKE '" + txt_consultar.Text.ToString() + "%'";

                conexaoDb.Close();
//Consulta      
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
