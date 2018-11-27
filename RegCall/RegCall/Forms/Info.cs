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

namespace RegCall
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        private void Info_Load(object sender, EventArgs e)
        {
            UC_Inicio uc_inicio = new UC_Inicio();
            AdicionarControleAoPanel(uc_inicio);
            pnl_menuAtivo.Top = btn_iniciar.Top + 12;
//HudButtons
            pnl_inicioT.Top = btn_iniciar.Top + 12;
            pnl_lojaHubT.Top = btn_lojaHub.Top + 12;
            pnl_utilidadesT.Top = btn_utilidades.Top + 12;
            pnl_verificacoesT.Top = btn_verificacoes.Top + 12;
            pnl_contatosUteisT.Top = btn_contatosUteis.Top + 12;
            pnl_configuracoesT.Top = btn_configuracoes.Top + 12;
            pnl_sobreT.Top = btn_sobre.Top + 12;
        }        
        private void AdicionarControleAoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnl_fundo.Controls.Clear();
            pnl_fundo.Controls.Add(c);
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            UC_Inicio uc_inic = new UC_Inicio();
            AdicionarControleAoPanel(uc_inic);
            pnl_menuAtivo.Top = btn_iniciar.Top + 12;            
        }
        private void btn_lojaHub_Click(object sender, EventArgs e)
        {
            UC_LojaHub uc_loja = new UC_LojaHub();
            AdicionarControleAoPanel(uc_loja);
            pnl_menuAtivo.Top = btn_lojaHub.Top + 12;
        }
        private void btn_utilidades_Click(object sender, EventArgs e)
        {
            UC_Utilidades uc_util = new UC_Utilidades();
            AdicionarControleAoPanel(uc_util);
            pnl_menuAtivo.Top = btn_utilidades.Top + 12;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UC_Verificacoes uc_verif = new UC_Verificacoes();
            AdicionarControleAoPanel(uc_verif);
            pnl_menuAtivo.Top = btn_verificacoes.Top + 12;
        }
        private void btn_contatosUteis_Click(object sender, EventArgs e)
        {
            UC_ContatosUteis uc_cont = new UC_ContatosUteis();
            AdicionarControleAoPanel(uc_cont);
            pnl_menuAtivo.Top = btn_contatosUteis.Top + 12;
        }
        private void btn_configuracoes_Click(object sender, EventArgs e)
        {
            UC_Configuracoes uc_config = new UC_Configuracoes();
            AdicionarControleAoPanel(uc_config);
            pnl_menuAtivo.Top = btn_configuracoes.Top + 12;
        }
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            UC_Sobre uc_sob = new UC_Sobre();
            AdicionarControleAoPanel(uc_sob);
            pnl_menuAtivo.Top = btn_sobre.Top + 12;
        }
    }
}
