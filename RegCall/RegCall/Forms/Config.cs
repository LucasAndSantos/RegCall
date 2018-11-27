using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegCall
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Config_Load(object sender, EventArgs e)
        {
            Left = 240;
            string[] abrirRemote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\abrirRemote.txt");
            string[] registro = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt");
            string[] remote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt");
            string[] salvarRegistro = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\salvarRegistro.txt");
            string[] sempreVisivel = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt");
            string[] rangeServer = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\rangeServer.txt");

            string _abrirRemote = abrirRemote[0];
            string _registro = registro[0];
            string _remote = remote[0];
            string _salvarRegistro = salvarRegistro[0];
            string _sempreVisivel = sempreVisivel[0];
            string _rangeServer = rangeServer[0];

            if (_sempreVisivel == "1")
            {
                ckb_visivel.Checked = true;
            }
            if (_sempreVisivel == "0")
            {
                ckb_visivel.Checked = false;
            }
            if (_registro == "1")
            {
                ckb_registro.Checked = true;
                button5.Enabled = true;
                txt_registro.Enabled = true;
                txt_registro.ForeColor = Color.Black;
                txt_registro.BackColor = Color.White;
                button5.Enabled = true;
            }
            if (_registro == "0")
            {
                ckb_registro.Checked = false;
                button5.Enabled = false;
                txt_registro.Enabled = false;
                txt_registro.ForeColor = Color.White;
                txt_registro.BackColor = Color.Black;
                button5.Enabled = false;
            }

            if (_remote == "1")
            {
                ckb_remote.Checked = true;
                txt_remote.Enabled = true;
                txt_remote.ForeColor = Color.Black;
                txt_remote.BackColor = Color.White;
                txt_remote.ReadOnly = false;
                btn_abrirEm.Enabled = true;
            }            
            if (_remote == "0")
            {
                ckb_remote.Checked = false;
                txt_remote.Enabled = false;
                txt_remote.ForeColor = Color.White;
                txt_remote.BackColor = Color.Black;
                txt_remote.ReadOnly = true;
                btn_abrirEm.Enabled = false ;
            }
            txt_registro.Text = _salvarRegistro;
            txt_remote.Text = _abrirRemote;
            txt_rangeServer.Text = _rangeServer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
//sempreVisivel
            if (ckb_visivel.Checked)
            {
                string[] sempreVisivel = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt");                
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt", "1");
            }
            if (!ckb_visivel.Checked)
            {
                string[] sempreVisivel = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt", "0");
            }
//registro
            if (ckb_registro.Checked)
            {
                string[] registro = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt", "1");
            }
            if (!ckb_registro.Checked)
            {
                string[] registro = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt", "0");
            }
//remote
            if (ckb_remote.Checked)
            {
                string[] remote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt", "1");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\abrirRemote.txt", txt_remote.Text);
            }
            if (!ckb_remote.Checked)
            {
                string[] remote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt", "0");
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\abrirRemote.txt", @"C:\");
            }
//RangeServer
            if (ckb_rangeServer.Checked)
            {
                string[] rangeServer = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\rangeServer.txt");                
                File.WriteAllText(@"C:\DPaschoal\DP-Servicedesk\Configuracao\rangeServer.txt", txt_rangeServer.Text);
            }            
//RefreshForm1
            ((MainForm)this.Owner).Update();
            this.Close();            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txt_registro.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txt_remote.Text);
            MessageBox.Show("Copie o caminho completo do programa .exe que deseja abrir \r\ncole no campo de texto com o nomeDoPrograma.exe \r\n\r\nNao esqueca de salvar!", "Procedimento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txt_remote_MouseClick(object sender, MouseEventArgs e)
        {}
        private void ckb_remote_MouseClick(object sender, MouseEventArgs e)
        {}
        private void ckb_registro_Click(object sender, EventArgs e)
        {
            if (ckb_registro.Checked)
            {
                txt_registro.Enabled = true;
                txt_registro.ForeColor = Color.Black;
                txt_registro.BackColor = Color.White;
                button5.Enabled = true;
            }
            else
            {
                txt_registro.Enabled = false;
                txt_registro.ForeColor = Color.White;
                txt_registro.BackColor = Color.Black;
                button5.Enabled = false;
            }
        }

        private void ckb_remote_Click(object sender, EventArgs e)
        {
            if (ckb_remote.Checked)
            {
                txt_remote.Enabled = true;
                txt_remote.ForeColor = Color.Black;
                txt_remote.BackColor = Color.White;
                txt_remote.ReadOnly = false;
                btn_abrirEm.Enabled = true;
            }
            else
            {
                txt_remote.Enabled = false;
                txt_remote.ForeColor = Color.White;
                txt_remote.BackColor = Color.Black;
                txt_remote.ReadOnly = true;
                btn_abrirEm.Enabled = false;
            }
        }

        private void btn_padrao_Click(object sender, EventArgs e)
        {
            ckb_visivel.Checked = true;
            ckb_remote.Checked = false;
            ckb_registro.Checked = false;

            txt_registro.Enabled = false;
            txt_registro.ForeColor = Color.White;
            txt_registro.BackColor = Color.Black;
            button5.Enabled = false;

            txt_remote.Enabled = false;
            txt_remote.ForeColor = Color.White;
            txt_remote.BackColor = Color.Black;
            txt_remote.ReadOnly = true;
            btn_abrirEm.Enabled = false;

            ckb_rangeServer.Checked = true;
            txt_rangeServer.Enabled = true;
            txt_rangeServer.ForeColor = Color.Black;
            txt_rangeServer.BackColor = Color.White;
            txt_rangeServer.Text = "20";

            MessageBox.Show("Nao esqueca de salvar", "!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ckb_rangeServer_Click(object sender, EventArgs e)
        {
            if (ckb_rangeServer.Checked)
            {
                txt_rangeServer.Enabled = true;
                txt_rangeServer.ForeColor = Color.Black;
                txt_rangeServer.BackColor = Color.White;
            }
            if (!ckb_rangeServer.Checked)
            {
                txt_rangeServer.Enabled = false;
                txt_rangeServer.ForeColor = Color.White;
                txt_rangeServer.BackColor = Color.Black;
            }
        }
    }
}
