using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RegCall
{
    public partial class UC_Utilidades : UserControl
    {
        public UC_Utilidades()
        {
            InitializeComponent();
        } 
        
        public void LojaIncorreta()
        {            
            if (txt_loja.Text.Length != 3)
            {
                MessageBox.Show("numero da loja incorreto! \r\n\r\n Favor informar um numero de loja válido", "Numero incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
        }
        private void btn_tiControle_Click(object sender, EventArgs e)
        {
            LojaIncorreta();
            try
            {
                Process.Start(@"\\server" + txt_loja.Text + @"\raiz\ti\controle");
            }
            catch (Exception)
            {
                MessageBox.Show("Loja não encontrada!\r\nVerifique o numero da loja informada.\r\nCaso o erro persista, verifique se o server"
                    + txt_loja.Text+ " está ligado\r\n\r\n", "Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_lentidao_Click(object sender, EventArgs e)
        {
            LojaIncorreta();
            if (txt_loja.Text.Length == 3)
            {
                string ipV;               
                char compararIp = txt_loja.Text[1];
                char compareip = '0';
                if (compararIp == compareip)
                {
                    ipV = "10.20" + txt_loja.Text[0] + "." + txt_loja.Text[2] + ".1";                   
                }
                else
                {
                    ipV = "10.20" + txt_loja.Text[0] + "." + txt_loja.Text[1] + txt_loja.Text[2] + ".1";                    
                }
                string ip = ("/C ping " + ipV + " -t");
                Process.Start("cmd.exe", ip);
            }           
        }
        private void btn_notas_Click(object sender, EventArgs e)
        {
            LojaIncorreta();
            try
            {
                Process.Start(@"\\server" + txt_loja.Text + @"\sac\int_sap\venda\nf");
            }
            catch (Exception)
            {
                MessageBox.Show("Loja não encontrada!\r\nVerifique o numero da loja informada.\r\nCaso o erro persista, verifique se o server"
                    + txt_loja.Text + " está ligado\r\n\r\n", "Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe","sapfacil.dpaschoal.com.br");            
        }
        private void btn_dpaOnline_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe","dpaonline/especial/N1UsersQuery.asp");
        }
        private void btn_fsist_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "fsist.com.br/#imprimir");
        }
        private void btn_fazenda_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "www.nfe.fazenda.gov.br/portal/principal.aspx");
        }
        private void btn_procedimentos_Click(object sender, EventArgs e)
        {
            Process.Start(@"P:\CompTIServiceDesk\Administrativo\Procedimentos_Cherwell\Ativos");
        }
        private void btn_links_Click(object sender, EventArgs e)
        {
            LojaIncorreta();

            if (txt_loja.Text.Length == 3)
            {
                string ipV1;
                string ipV2;
                char compararIp = txt_loja.Text[1];
                char compareip = '0';
                if (compararIp == compareip)
                {
                    ipV1 = "10.24" + txt_loja.Text[0] + "." + txt_loja.Text[2] + ".1";
                    ipV2 = "10.22" + txt_loja.Text[0] + "." + txt_loja.Text[2] + ".1";
                }
                else
                {
                    ipV1 = "10.24" + txt_loja.Text[0] + "." + txt_loja.Text[1] + txt_loja.Text[2] + ".1";
                    ipV2 = "10.22" + txt_loja.Text[0] + "." + txt_loja.Text[1] + txt_loja.Text[2] + ".1";
                }
                string ip1 = ("/C ping " + ipV1 + " -t");
                string ip2 = ("/C ping " + ipV2 + " -t");
                Process.Start("cmd.exe", ip1);
                Process.Start("cmd.exe", ip2);
            }
        }
        private void btn_switch_Click(object sender, EventArgs e)
        {
            LojaIncorreta();
            if (txt_loja.Text.Length == 3)
            {
                string ipV;
                char compararIp = txt_loja.Text[1];
                char compareip = '0';
                if (compararIp == compareip)
                {
                    ipV = "10.20" + txt_loja.Text[0] + "." + txt_loja.Text[2] + ".10";
                }
                else
                {
                    ipV = "10.20" + txt_loja.Text[0] + "." + txt_loja.Text[1] + txt_loja.Text[2] + ".10";
                }
                string ip = ("/C ping " + ipV + " -t");
                Process.Start("cmd.exe", ip);
            }
        }
        private void btn_pabx_Click(object sender, EventArgs e)
        {
            LojaIncorreta();
            if (txt_loja.Text.Length == 3)
            {
                string ipV;
                char compararIp = txt_loja.Text[1];
                char compareip = '0';
                if (compararIp == compareip)
                {
                    ipV = "10.21" + txt_loja.Text[0] + "." + txt_loja.Text[2] + ".20";
                }
                else
                {
                    ipV = "10.21" + txt_loja.Text[0] + "." + txt_loja.Text[1] + txt_loja.Text[2] + ".20";
                }
                string ip = ("/C ping " + ipV + " -t");
                Process.Start("cmd.exe", ip);
            }
        }
    }
}
