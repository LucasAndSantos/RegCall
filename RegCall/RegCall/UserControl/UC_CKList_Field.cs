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
    public partial class UC_CKList_Field : UserControl
    {
        public string checkListInfoDataField = "";

        public UC_CKList_Field()
        {
            InitializeComponent();
        }
        private void UC_CKList_Field_Load(object sender, EventArgs e)
        {}
        public void btn_salvar_field_Click(object sender, EventArgs e)
        {
            Chk();
            CheckLists.ActiveForm.Close();
        }
        public void Chk()
        {
            string equipamento = txt_equipamento.Text;
            string usuario = txt_usuario.Text;
            string sistema = txt_sistemaOperacional.Text;
            string marca = txt_marca.Text;
            string modelo = txt_modelo.Text;
            string patrimonio = txt_patrimonio.Text;
            string numeroDeSerie = txt_numeroDeSerie.Text;
            string centroDeCusto = txt_centroDeCusto.Text;

            

            checkListInfoDataField = "CheckList - Field\r\n\r\n" +
               "Equipamento: " + txt_equipamento.Text + "\r\n" +
               "Usuário de login: " + txt_usuario.Text + "\r\n" +
               "Sistema Operacional: " + txt_sistemaOperacional.Text + "\r\n" +
               "Marca: " + txt_marca.Text + "\r\n" +
               "Modelo: " + txt_modelo.Text + "\r\n" +
               "Patrimônio: " + txt_patrimonio.Text + "\r\n" +
               "Número de série: " + txt_numeroDeSerie.Text + "\r\n" +
               "Centro de Custo: " + txt_centroDeCusto.Text;

            MessageBox.Show(checkListInfoDataField);           
        }
        private void btn_limpar_field_Click(object sender, EventArgs e)
        {
            txt_centroDeCusto.Text = "";
            txt_equipamento.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_numeroDeSerie.Text = "";
            txt_patrimonio.Text = "";
            txt_sistemaOperacional.Text = "";
            txt_usuario.Text = "";            
        }
        private void btn_cancelar_field_Click(object sender, EventArgs e)
        {
            CheckLists.ActiveForm.Close();
        }
    }
}
