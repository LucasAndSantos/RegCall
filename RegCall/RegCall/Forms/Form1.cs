using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Diagnostics;

namespace RegCall
{
    public partial class MainForm : Form
    {
        string cpNome;
        string cpLjCd;
        string cpTelefone;
        string cpIp;
        string cpDescricao;
//CheckListInfo
        string CheckList;        

        public MainForm()
        {
            InitializeComponent();
            Text = ("RegCall - "+Environment.UserName);
        }       
        private void Main_Load(object sender, EventArgs e)
        {
            Left = 0;
            TopMost = true;
        }
//UpdatePeloForm2
        public void Update()
        {
            string[] sempreVisivel = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt");
            string sv = sempreVisivel[0];
            if (sv == "1")
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
            Refresh();
        }
        private void txt_loja_TextChanged(object sender, EventArgs e)
        {
            if (txt_LjCd.Text.Length == 4)
            {
                txt_Ip.Text = "";
                txt_Telefone.Text = "";
            }
            if (txt_LjCd.Text.Length == 3)
            {
                txt_Telefone.Text = "7" + txt_LjCd.Text;
                char compararIp = txt_LjCd.Text[1];
                char compareip = '0';
                
                if (compararIp == compareip)
                {
                    if (txt_LjCd.Text == "600")
                    {
                        txt_Telefone.Text = "2001-";
                        txt_Ip.Text = "10.33.";
                    }
                    else
                    {
                        txt_Ip.Text = "10.20" + txt_LjCd.Text[0] + "." + txt_LjCd.Text[2] + ".";
                    }
                }
                else
                {
                    txt_Ip.Text = "10.20" + txt_LjCd.Text[0] + "." + txt_LjCd.Text[1] + txt_LjCd.Text[2] + ".";
                }
            }
            if (txt_LjCd.Text.Length == 2)
            {
                if (txt_LjCd.Text == "01")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.33..";
                }
                if (txt_LjCd.Text == "04")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.26.";
                }
                if (txt_LjCd.Text == "05")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.9.";
                }
                if (txt_LjCd.Text == "07")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.176.";
                }
                if (txt_LjCd.Text == "08")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.13.";
                }
                if (txt_LjCd.Text == "09")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.21.";
                }
                if (txt_LjCd.Text == "10")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.3.";
                }
                if (txt_LjCd.Text == "11")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.12.";
                }
                if (txt_LjCd.Text == "12")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.8.";
                }
                if (txt_LjCd.Text == "13")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.178.";
                }
                if (txt_LjCd.Text == "14")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.11.";
                }
                if (txt_LjCd.Text == "15")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.14.";
                }
                if (txt_LjCd.Text == "16")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.16.";
                }
                if (txt_LjCd.Text == "18")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.190.";
                }
                if (txt_LjCd.Text == "19")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.178.";
                }
                if (txt_LjCd.Text == "20")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.30.65.";
                }
                if (txt_LjCd.Text == "21")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.202.65.";
                }
                if (txt_LjCd.Text == "22")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.202.65.";
                }
                if (txt_LjCd.Text == "23")
                {
                    txt_Telefone.Text = "20" + txt_LjCd.Text + "-";
                    txt_Ip.Text = "10.200.26.";
                }
            }
            if (txt_LjCd.Text.Length == 1 && txt_LjCd.Text == "0")
            {
                txt_Ip.Text = "10.1..";
                txt_Telefone.Text = "";
            }
            if (txt_LjCd.Text.Length == 0 || txt_LjCd.Text == "00" || txt_LjCd.Text == "000" || txt_LjCd.Text == "0000")
            {
                txt_Ip.Text = "";
                txt_Telefone.Text = "";
            }
        }
        public void btn_CopiarIP_Click(object sender, EventArgs e)
        {
            BotaoCopiarIP();
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Text = "Nome";
            txt_LjCd.Text = "Loja";
            txt_Telefone.Text = "Telefone";
            txt_Ip.Text = "IP";
            txt_Descricao.Text = "Descrição\r\n\r\nUsuario informa que...";           

            txt_Descricao.ForeColor = Color.DarkGray;
            txt_Descricao.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            txt_LjCd.ForeColor = Color.DarkGray;
            txt_LjCd.Font = new Font(txt_Nome.Font, FontStyle.Italic);           
            txt_Telefone.ForeColor = Color.DarkGray;
            txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Italic);            
            txt_Ip.ForeColor = Color.DarkGray;
            txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            txt_Nome.ForeColor = Color.DarkGray;
            txt_Nome.Font = new Font(txt_Nome.Font, FontStyle.Italic);
        }
        //public void Check_List()
        //{
        //    UC_CKList_Field field = new UC_CKList_Field();
        //    int checkField = field.salvar;
        //    int comparaField = 1;

        //    UC_CKList_Telefonia telefonia = new UC_CKList_Telefonia();            
        //    int checkTelefonia = telefonia.salvar;
        //    int comparaTelefonia = 1;

        //    if (comparaField == checkField)
        //    {                
        //        CheckList = field.checkListInfoDataField;
        //    }
        //    if (comparaField != checkField)
        //    {
        //        CheckList = "";
        //    }
        //    if (comparaTelefonia == checkTelefonia)
        //    {
        //        CheckList = telefonia.checkListInfoDataTelefonia; ;
        //    }
        //    if (comparaTelefonia != checkTelefonia)
        //    {
        //        CheckList = "";
        //    }
        //}
        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            //Falta colocar condição para criar as pastas no diretorio ao clicar em copiar e não ao clicar em config

            //falta chamar as informações salvas em checklist  

            UC_CKList_Field uf = new UC_CKList_Field();
            uf.Chk();            

            return;
           
            
            if (txt_LjCd.Text.Length != 0)
            {
                if (txt_Nome.Text == "queda" || txt_Nome.Text == "Queda" || txt_Nome.Text == "QUEDA")
                {
                    txt_LjCd.Text = "0";
                    txt_Telefone.Text = "0";
                    txt_Ip.Text = "0";
                    txt_Descricao.Text = "Queda";
                }
                if (txt_Nome.Text == "muda" || txt_Nome.Text == "Muda" || txt_Nome.Text == "MUDA")
                {
                    txt_LjCd.Text = "0";
                    txt_Telefone.Text = "0";
                    txt_Ip.Text = "0";
                    txt_Descricao.Text = "Muda";
                }
                if (txt_LjCd.Text == "Loja")
                {
                    Dado_Incorreto();
                   return;
                }

                int verificaCentral = Convert.ToInt32(txt_LjCd.Text);

                if (txt_LjCd.Text == "0")
                {
                    Clipboard.SetText("Nome: " + txt_Nome.Text + "\r\n" + "Administração " + "Central"
                        + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text
                        + "\r\n" + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                }
                if (txt_LjCd.Text.Length == 2)
                {
                    Clipboard.SetText("Nome: " + txt_Nome.Text + "\r\n" + "CD: " + txt_LjCd.Text
                        + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                        + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                }
                if (txt_LjCd.Text.Length == 3)
                {
                    Clipboard.SetText("Nome: " + txt_Nome.Text + "\r\n" + "Loja/Hub: " + txt_LjCd.Text
                        + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                        + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                }
                if (txt_LjCd.Text.Length == 4)
                {
                    Clipboard.SetText("Nome: " + txt_Nome.Text + "\r\n" + "Representante/PAC: " + txt_LjCd.Text
                        + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                        + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                }
                if (txt_LjCd.Text == "00" || txt_LjCd.Text == "000" || txt_LjCd.Text == "0000")
                {
                    Dado_Incorreto();
                    Clipboard.SetText(" ");
                }
                if (verificaCentral != 0 && txt_LjCd.Text.Length == 1)
                {
                    Dado_Incorreto();
                    Clipboard.SetText(" ");
                }
            }
            else
            {
                Dado_Incorreto();
                return;
            }           
//SalvandoRegistro
            string[] registro = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt");
            string reg = registro[0];
            if (reg == "1")
            {
                string pastaAtual = DateTime.Now.ToString("dd_MM_yy");
                Directory.CreateDirectory(@"C:\DPaschoal\DP-Servicedesk\Registros\" + pastaAtual + "\\");
                string lojaHubNum = " - Usuario_" + Convert.ToString(txt_LjCd.Text);
                string arquivo = @"C:\DPaschoal\DP-Servicedesk\Registros\" + pastaAtual +"\\" + "Hora_" + DateTime.Now.ToString("HH-mm-ss")+ lojaHubNum + ".txt";
                if (!File.Exists(arquivo))
                {
                    using (StreamWriter padrao = new StreamWriter(arquivo))
                    {
                        if (txt_LjCd.Text == "0")
                        {
                            padrao.WriteLine("Nome: " + txt_Nome.Text + "\r\n" + "Administração " + "Central"
                                + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text
                                + "\r\n" + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                        }
                        if (txt_LjCd.Text.Length == 2)
                        {
                            padrao.WriteLine("Nome: " + txt_Nome.Text + "\r\n" + "CD: " + txt_LjCd.Text
                                + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                                + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                        }
                        if (txt_LjCd.Text.Length == 3)
                        {
                            padrao.WriteLine("Nome: " + txt_Nome.Text + "\r\n" + "Loja/Hub: " + txt_LjCd.Text
                                + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                                + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                        }
                        if (txt_LjCd.Text.Length == 4)
                        {
                            padrao.WriteLine("Nome: " + txt_Nome.Text + "\r\n" + "Representante/PAC: " + txt_LjCd.Text
                                + "\r\n" + "Telefone: " + txt_Telefone.Text + "\r\n" + "IP: " + txt_Ip.Text + "\r\n"
                                + "Descricao: Usuário informa que " + txt_Descricao.Text + CheckList);
                        }
                    }
                }
            }            
        }
        private void Dado_Incorreto()
        {
            MessageBox.Show("  Voce Precisa definir loja/CD para poder copiar" + "\r\n" + "\r\n" + "  - Central = 0" + "\r\n"
                    + "  - CD = 00 (2 digitos)" + "\r\n" + "  - Loja/Hub = 000 (3 digitos)" + "\r\n" + "  - Representante/PAC = 0000 (Codigo)" + "\r\n" 
                    + "\r\n" + "Caso precise registrar chamada muda ou queda, digite muda ou queda no campo 'Nome' " +
                    "e o sistema completara o resto e realizara o registro ao clicar em 'Copiar'",
                    "Valor inserido invalido!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void txt_LjCd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void btn_Refazer_Click(object sender, EventArgs e)
        {
            txt_Nome.Text = cpNome;
            txt_LjCd.Text = cpLjCd;
            txt_Telefone.Text = cpTelefone;
            txt_Ip.Text = cpIp;
            txt_Descricao.Text = cpDescricao;

            txt_Nome.ForeColor = Color.Black;
            txt_Nome.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            txt_LjCd.ForeColor = Color.Black;
            txt_LjCd.Font = new Font(txt_Nome.Font, FontStyle.Regular);            
            txt_Telefone.ForeColor = Color.Black;
            txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Regular);            
            txt_Ip.ForeColor = Color.Black;
            txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            txt_Descricao.ForeColor = Color.Black;
            txt_Descricao.Font = new Font(txt_Nome.Font, FontStyle.Regular);
        }       
//Configuracoes visuais
        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "Nome")
            {
                txt_Nome.Text = "";
                txt_Nome.ForeColor = Color.Black;
                txt_Nome.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            }
        }
        private void txt_Nome_Leave(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                txt_Nome.Text = "Nome";
                txt_Nome.ForeColor = Color.DarkGray;
                txt_Nome.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            }
        }
        private void txt_LjCd_Enter(object sender, EventArgs e)
        {
            if (txt_LjCd.Text == "Loja")
            {
                txt_LjCd.Text = "";
                txt_LjCd.ForeColor = Color.Black;
                txt_LjCd.Font = new Font(txt_Nome.Font, FontStyle.Regular);
                txt_Telefone.ForeColor = Color.Black;
                txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Regular);
                txt_Ip.ForeColor = Color.Black;
                txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            }           
        }
        private void txt_LjCd_Leave(object sender, EventArgs e)
        {
            if (txt_LjCd.Text == "")
            {
                txt_LjCd.Text = "Loja";
                txt_LjCd.ForeColor = Color.DarkGray;
                txt_LjCd.Font = new Font(txt_Nome.Font, FontStyle.Italic);
                txt_Telefone.Text = "Telefone";
                txt_Telefone.ForeColor = Color.DarkGray;
                txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Italic);
                txt_Ip.Text = "IP";
                txt_Ip.ForeColor = Color.DarkGray;
                txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            }            
        }
        private void txt_Telefone_Enter(object sender, EventArgs e)
        {
            if (txt_Telefone.Text == "Telefone")
            {
                txt_Telefone.Text = "";
                txt_Telefone.ForeColor = Color.Black;
                txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            }
        }
        private void txt_Telefone_Leave(object sender, EventArgs e)
        {
            if (txt_Telefone.Text == "")
            {
                txt_Telefone.Text = "Telefone";
                txt_Telefone.ForeColor = Color.DarkGray;
                txt_Telefone.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            }
        }
        private void txt_Descricao_Enter(object sender, EventArgs e)
        {
            if (txt_Descricao.Text == "Descrição\r\n\r\nUsuario informa que...")
            {
                txt_Descricao.Text = "";
                txt_Descricao.ForeColor = Color.Black;
                txt_Descricao.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            }
        }
        private void txt_Descricao_Leave(object sender, EventArgs e)
        {
            if (txt_Descricao.Text == "")
            {
                txt_Descricao.Text = "Descrição\r\n\r\nUsuario informa que...";
                txt_Descricao.ForeColor = Color.DarkGray;
                txt_Descricao.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            }
        }
        public void btn_config_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\DPaschoal\DP-Servicedesk\Configuracao");
            Directory.CreateDirectory(@"C:\DPaschoal\DP-Servicedesk\Registros");
//SempreVisivel
            string visivel = @"C:\DPaschoal\DP-Servicedesk\Configuracao\sempreVisivel.txt";
            if (!File.Exists(visivel))
            {
                using (StreamWriter padrao = new StreamWriter(visivel))
                {
                    padrao.WriteLine("1");
                }               
            }  
//Registro            
            string registro = @"C:\DPaschoal\DP-Servicedesk\Configuracao\registro.txt";
            if (!File.Exists(registro))
            {
                using (StreamWriter padrao = new StreamWriter(registro))
                {
                    padrao.WriteLine("0");
                }                
            }
//Remote
            string remote = @"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt";
            if (!File.Exists(remote))
            {
                using (StreamWriter padrao = new StreamWriter(remote))
                {
                    padrao.WriteLine("0");
                }
            }
//SalvarRegistro
            string salvarRegistro = @"C:\DPaschoal\DP-Servicedesk\Configuracao\salvarRegistro.txt";
            if (!File.Exists(salvarRegistro))
            {
                using (StreamWriter padrao = new StreamWriter(salvarRegistro))
                {
                    padrao.WriteLine("C:\\DPaschoal\\DP-Servicedesk\\Registros");
                }                
            }
//AbrirRemote
            string abrirRemote = @"C:\DPaschoal\DP-Servicedesk\Configuracao\abrirRemote.txt";
            if (!File.Exists(abrirRemote))
            {
                using (StreamWriter padrao = new StreamWriter(abrirRemote))
                {
                    padrao.WriteLine(@"C:\");
                }                
            }
//RangeDoServerPadrao
            string rangeServer = @"C:\DPaschoal\DP-Servicedesk\Configuracao\rangeServer.txt";
            if (!File.Exists(rangeServer))
            {
                using (StreamWriter padrao = new StreamWriter(rangeServer))
                {
                    padrao.WriteLine("20");
                }
                MessageBox.Show("Aplicando configurações Padrao! \r\n \r\n" +
                     "Criando Diretorio em: \r\nC:\\DPaschoal\\DP-Servicedesk\\Configuracao", "Configurando!");
            }
            Config configuracao = new Config();
            configuracao.Owner = this;
            configuracao.Show();
        }       
        private void MainForm_Shown(object sender, EventArgs e)
        {}
        private void MainForm_Enter(object sender, EventArgs e)
        {}
        private void txt_Ip_Enter(object sender, EventArgs e)
        {
            if (txt_Ip.Text == "IP")
            {
                txt_Ip.Text = "";
                txt_Ip.ForeColor = Color.Black;
                txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Regular);
            }
        }
        private void txt_Ip_Leave(object sender, EventArgs e)
        {
            if (txt_Ip.Text == "")
            {
                txt_Ip.Text = "IP";
                txt_Ip.ForeColor = Color.DarkGray;
                txt_Ip.Font = new Font(txt_Nome.Font, FontStyle.Italic);
            }
        }
        private void btn_pingServer_Click(object sender, EventArgs e)
        {            
            if (txt_LjCd.Text.Length == 3)
            {
                string ipV;
                string ipServer;          
                char compararIp = txt_LjCd.Text[1];
                char compareip = '0';
                if (compararIp == compareip)
                {
                    ipServer = "10.20" + txt_LjCd.Text[0] + "." + txt_LjCd.Text[2] + ".";
                    ipV = ipServer;
                }
                else
                {
                    ipServer = "10.20" + txt_LjCd.Text[0] + "." + txt_LjCd.Text[1] + txt_LjCd.Text[2] + ".";
                    ipV = ipServer;
                }

                string[] rangeServer = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\rangeServer.txt");
                string range = rangeServer[0];

                string ip = ("/C ping " + ipV + range + " -t");
                Process.Start("cmd.exe", ip);
            }
            else
            {
                MessageBox.Show("Ip informado incorreto", "Informacao invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_pingIP_Click(object sender, EventArgs e)
        {
            string ip = ("/C ping " + txt_Ip.Text + " -t");
            Process.Start("cmd.exe", ip);            
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            Info informacoes = new Info();
            informacoes.Show();
        }
        private void BotaoCopiarIP()
        {
            if (txt_Ip.Text.Length != 0 && txt_Ip.Text != "IP")
            {
                Clipboard.SetText(txt_Ip.Text);

                string[] remote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\remote.txt");
                string rmt = remote[0];
                if (rmt == "1")
                {
                    string[] abrirRemote = File.ReadAllLines(@"C:\DPaschoal\DP-Servicedesk\Configuracao\abrirRemote.txt");
                    string abrir = abrirRemote[0];
                    System.Diagnostics.Process.Start(abrir);
                }
            }
            else
            {
                Clipboard.SetText(" ");
                MessageBox.Show("Informe o endereco de IP", "?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public void txt_Ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BotaoCopiarIP();
            }
        }
        private void btn_checkList_Click(object sender, EventArgs e)
        {
            CheckLists ckList = new CheckLists();
            ckList.Show();
        }
    }
}
