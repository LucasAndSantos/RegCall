using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegCall
{
    public partial class UC_CKList_Telefonia : UserControl
    {
        public string checkListInfoDataTelefonia = "";

        public UC_CKList_Telefonia()
        {
            InitializeComponent();
        }
        private void UC_CKList_Telefonia_Load(object sender, EventArgs e)
        {}
        private void btn_salvar_telefonia_Click(object sender, EventArgs e)
        {
            string fazLigacao = "Sim";
            string recebeLigacao = "Sim";
            string chiado = "Sim";
            string queda = "Sim";
            string transferencia = "Sim";
            string voip = "Sim";
           
            if (!rdb_fazLig_s.Checked)
            {
                fazLigacao = "Não";
            }
            if (!rdb_recbLig_s.Checked)
            {
                recebeLigacao = "Não";
            }
            if (!rdb_chiado_s.Checked)
            {
                chiado = "Não";
            }
            if (!rdb_queda_s.Checked)
            {
                queda = "Não";
            }
            if (!rdb_transferencia_s.Checked)
            {
                transferencia = "Não";
            }
            if (!rdb_voip_s.Checked)
            {
                voip = "Não";
            }
            checkListInfoDataTelefonia = 
                "\r\n\r\nCheckList Telefonia \r\n\r\n\r" + "Quais Ramais Apresentam o problema? " + "\r\n" + txt_ramais.Text +"\r\n" + "\r\n" 
                + "Faz ligação? " + "\r\n" + fazLigacao + "\r\n" + "\r\n" 
                + "Recebe Ligação? " + "\r\n" + recebeLigacao + "\r\n" + "\r\n"
                + "Apresenta Chiado? " + "\r\n" + chiado + "\r\n" + "\r\n"
                + "Apresenta quedas? " + "\r\n" + queda + "\r\n" + "\r\n"
                + "Realiza transferência?" + "\r\n" + transferencia + "\r\n" + "\r\n"
                + "Liga via Voip?" + "\r\n" + voip;

            MessageBox.Show(checkListInfoDataTelefonia);
        }
        private void btn_cancelar_telefonia_Click(object sender, EventArgs e)
        {
            CheckLists.ActiveForm.Close();
        }
        private void btn_limpar_telefonia_Click(object sender, EventArgs e)
        {
            txt_ramais.Text = "";
            rdb_fazLig_s.Checked = true;
            rdb_recbLig_s.Checked = true;
            rdb_chiado_s.Checked = true;
            rdb_queda_s.Checked = true;
            rdb_transferencia_s.Checked = true;
            rdb_voip_s.Checked = true;
        }
    }
}
