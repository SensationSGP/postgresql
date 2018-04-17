using Microsoft.Win32;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;


namespace postgresql
{
    

    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            {

            }
            List<string> arquivos = new List<string>();


        }

        private void frmPrincipal_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime newDate = DateTime.Now;
            DateTime oldDate = new DateTime(2018, 04, 15, 00, 00, 00);
            if (oldDate < newDate)
            {
                System.Windows.Forms.MessageBox.Show("Esse aplicativo expirou, favor procurar o setor Service Desk", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            {
                {
                    System.Windows.Forms.MessageBox.Show("EXECUTAR ESSE APLICATIVO APENAS NA VERSÃO DO INTEGRA 6.00a!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                {
                    string pdvprograms = @"C:\Sistemas\PDVAtual\Programs\";
                    string pdvatualiza = @"C:\Sistemas\PDVAtual\Atualiza\";
                    string integraprograms = @"C:\Vdf7\Integra\Programs\";
                    string integraatualiza = @"C:\Vdf7\Integra\Atualiza\";
                    string dll = "msvcr120.dll";

                    string system32 = @"C:\Windows\System32\";
                    string syswow64 = @"C:\Windows\SysWOW64\";
                    string caminho = @"C:\AtualSistemas\";
                    string dllconexao = "Npgsql.dll";
                    string dllnet = "System.Threading.Tasks.Extensions.dll";

                    try
                    {
                        if (Directory.Exists(pdvatualiza) == true)
                        {
                            if (File.Exists(pdvatualiza + dll) == false)
                            {
                                string urlArquivo = "http://www.atualsistemas.net/ftp/Integra/msvcr120.dll";
                                string caminhoArquivo = pdvatualiza + dll;
                                WebClient client = new WebClient();
                                client.DownloadFile(urlArquivo, caminhoArquivo);
                            }
                        }
                        if (Directory.Exists(pdvprograms) == true)
                        {
                            if (File.Exists(pdvprograms + dll) == false)
                            {
                                File.Copy(pdvatualiza + dll, pdvprograms + dll);
                            }
                        }
                        if (Directory.Exists(integraatualiza) == true)
                        {
                            if (File.Exists(integraatualiza + dll) == false)
                            {
                                string urlArquivo = "http://www.atualsistemas.net/ftp/Integra/msvcr120.dll";
                                string caminhoArquivo = integraatualiza + dll;
                                WebClient client = new WebClient();
                                client.DownloadFile(urlArquivo, caminhoArquivo);
                            }
                        }
                        if (Directory.Exists(integraprograms) == true)
                        {
                            if (File.Exists(integraprograms + dll) == false)
                            {
                                File.Copy(integraatualiza + dll, integraprograms + dll);
                            }
                        }
                        if (Directory.Exists(system32) == true)
                        {
                            if (File.Exists(system32 + dllconexao) == false)
                            {
                                File.Copy(caminho + dllconexao, system32 + dllconexao);
                            }
                        }
                        if (Directory.Exists(system32) == true)
                        {
                            if (File.Exists(system32 + dllnet) == false)
                            {
                                File.Copy(caminho + dllnet, system32 + dllnet);
                            }
                        }
                        if (Directory.Exists(syswow64) == true)
                        {
                            if (File.Exists(syswow64 + dllconexao) == false)
                            {
                                File.Copy(caminho + dllconexao, syswow64 + dllconexao);
                            }
                        }
                        if (Directory.Exists(syswow64) == true)
                        {
                            if (File.Exists(syswow64 + dllnet) == false)
                            {
                                File.Copy(caminho + dllnet, syswow64 + dllnet);
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnTeste_Click(object sender, RoutedEventArgs e)
        {
            {
                lblTesteConexao.Content = " Testando conexão!!! ";
                lblEmpresaBD.Visibility = Visibility.Collapsed;
                lblListaBD.Visibility = Visibility.Collapsed;
            }
            string serverbd = txtServer.Text;
            string portabd = txtPorta.Text;
            string userbd = txtUsuario.Text;
            string userpadrao = "postgres";
            string bdsql = txtBD.Text;
            string bdsqlpadrao = "postgres";
            string senhabd = txtSenhapostgre.Password;
            string senhapadrao = "pg@atualDev";
            string nomebd = txtNomeBD.Text;
            string localrestore = txtLocalBD.Text;
            string selectcadsys = "SELECT licenca FROM cadsys;";

            string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";
            string connectionString2 = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userbd + "; password=" + senhabd + "; Database=" + bdsqlpadrao + ";";

            if (rbSenhaPadrao.IsChecked == true)
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            lblTesteConexao.Content = "Conexão realizada com sucesso!!!";
                            lblTesteConexao.Foreground = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            lblTesteConexao.Content = "Não foi possível conectar ao Banco de Dados!!!";
                            lblTesteConexao.Foreground = new SolidColorBrush(Colors.Red);
                        }
                    }
                    {
                        conn.Close();
                    }
                }
                catch
                {
                    lblTesteConexao.Content = "Não foi possível conectar ao Banco de Dados!!!";
                    lblTesteConexao.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
            if (rbSenhainstala.IsChecked == true)
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(connectionString2);
                    conn.Open();
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            lblTesteConexao.Content = "Conexão realizada com sucesso!!!";
                            lblTesteConexao.Foreground = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            lblTesteConexao.Content = "Não foi possível conectar ao Banco de Dados!!!";
                            lblTesteConexao.Foreground = new SolidColorBrush(Colors.Red);
                        }
                    }
                    {
                        conn.Close();
                    }
                }
                catch
                {
                    lblTesteConexao.Content = "Não foi possível conectar ao Banco de Dados!!!";
                    lblTesteConexao.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
        }

        private void btnCriarBD_Click(object sender, RoutedEventArgs e)
        {
            lblEmpresaBD.Visibility = Visibility.Collapsed;
            lblListaBD.Visibility = Visibility.Collapsed;
            string serverbd = txtServer.Text;
            string portabd = txtPorta.Text;
            string userbd = txtUsuario.Text;
            string userpadrao = "postgres";
            string bdsql = txtBD.Text;
            string bdsqlpadrao = "postgres";
            string senhabd = txtSenhapostgre.Password;
            string senhapadrao = "pg@atualDev";
            string nomebd = txtNomeBD.Text;
            string localrestore = txtLocalBD.Text;
            string comandocriabd = "CREATE DATABASE integrapgsql WITH OWNER = postgres TEMPLATE = template0 ENCODING = 'SQL_ASCII' TABLESPACE = pg_default LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252' CONNECTION LIMIT = -1;";

            string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                {
                    NpgsqlCommand command = new NpgsqlCommand(comandocriabd, conn);
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        int i;
                        for (i = 0; i < dr.FieldCount; i++)
                        {
                            Console.Write("{0} \t", dr[i]);
                        }
                        Console.WriteLine();
                    }
                }
                {

                    conn.Close();
                    System.Windows.Forms.MessageBox.Show("Banco de dados criado com Sucesso!!", "Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Erro!!! Banco de dados não foi criado.\nProvavelmente já deve existir um BD com o nome 'integrapgsql. \nPor favor, renomeie antes de continuar!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnListarBD_Click(object sender, RoutedEventArgs e)
        {
            lblEmpresaBD.Visibility = Visibility.Collapsed;
            lblListaBD.Visibility = Visibility.Collapsed;
            string serverbd = txtServer.Text;
            string portabd = txtPorta.Text;
            string userbd = txtUsuario.Text;
            string userpadrao = "postgres";
            string bdsql = txtBD.Text;
            string bdsqlpadrao = "postgres";
            string senhabd = txtSenhapostgre.Password;
            string senhapadrao = "pg@atualDev";
            string nomebd = txtNomeBD.Text;
            string localrestore = txtLocalBD.Text;
            string comandolistabd = "SELECT datname FROM pg_database WHERE datname LIKE '%int%';";

            string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";

            cbxListaBD.Items.Clear();

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(comandolistabd, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();

                        while (dr.Read())
                        {
                            cbxListaBD.Items.Add(dr["datname"].ToString());
                        }
                    }
                    {
                        conn.Close();
                        cbxListaBD.SelectedIndex = 0;
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Erro!!! O Sistema não conseguiu listar os bancos cadastrados.\nProvavelmente o usuário 'postgres' não está com as permissões corretas", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnBuscarBD_Click(object sender, RoutedEventArgs e)
        {
            lblEmpresaBD.Visibility = Visibility.Collapsed;
            lblListaBD.Visibility = Visibility.Collapsed;
            System.Windows.Forms.OpenFileDialog ofd1 = new System.Windows.Forms.OpenFileDialog();

            //define as propriedades do controle OpenFileDialog
            ofd1.Multiselect = false;
            ofd1.Title = "Selecionar Arquivo";
            ofd1.InitialDirectory = @"C:\VDF7\Integra\Base0001";
            //filtra para exibir os arquivos
            ofd1.Filter = "Arquivo (*.tar;)|*.tar;|Backup (*.backup;)| *.backup;|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = false;
            ofd1.ShowReadOnly = true;

            DialogResult dr = ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    try
                    {
                        txtLocalBD.Text = (arquivo);
                        //arquivos.Add(arquivo);
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        System.Windows.Forms.MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                        "Mensagem : " + ex.Message + "\n\n" +
                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Você pode não ter permissão para ler o arquivo , ou " +
                                        " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }

        private void btnRenomearBD_Click(object sender, RoutedEventArgs e)
        {
            lblEmpresaBD.Visibility = Visibility.Collapsed;
            lblListaBD.Visibility = Visibility.Collapsed;
            string serverbd = txtServer.Text;
            string portabd = txtPorta.Text;
            string userbd = txtUsuario.Text;
            string userpadrao = "postgres";
            string bdsql = txtBD.Text;
            string bdsqlpadrao = "postgres";
            string senhabd = txtSenhapostgre.Password;
            string senhapadrao = "pg@atualDev";
            string nomebd = txtNomeBD.Text;
            string localrestore = txtLocalBD.Text;
            string nomebdold = cbxListaBD.SelectionBoxItem.ToString();
            string comandorenomeiabd = ("ALTER DATABASE \"" + nomebdold + "\" RENAME TO  \"" + nomebd + "\";");

            string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                {
                    NpgsqlCommand command = new NpgsqlCommand(comandorenomeiabd, conn);
                    NpgsqlDataReader dr = command.ExecuteReader();
                }
                {
                    conn.Close();
                    cbxListaBD.Items.Clear();
                    txtNomeBD.Clear();
                    System.Windows.Forms.MessageBox.Show("O BD " + nomebdold + " foi renomeado com sucesso para '" + nomebd + "'", "Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("O sistema não pode completar a operação!! Por favor verifique as configurações!!\nProvavelmente já deve existir um BD com esse nome '" + nomebd + "'", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxListaBD.Items.Clear();
                txtNomeBD.Clear();

            }

        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Se tiver algum dado no BD 'integrapgsql' será apagado!!\nDeseja Continuar??", "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                lblEmpresaBD.Visibility = Visibility.Collapsed;
                lblListaBD.Visibility = Visibility.Collapsed;
                string serverbd = txtServer.Text;
                string portabd = txtPorta.Text;
                string userpadrao = "postgres";
                string senhapadrao = "pg@atualDev";
                string bdsqlpadrao = "integrapgsql";
                string pgDumpPath = @"C:\Progra~1\PostgreSQL\9.4\bin\pg_restore.exe";
                string host = txtServer.Text;
                string port = txtPorta.Text;
                string database = "integrapgsql";
                string user = "postgres";
                string password = "pg@atualDev";
                string arquivo = txtLocalBD.Text.ToString();
                string comandolistabd = "drop schema public cascade;" + "create schema public;";
                //string selectcadsys = "SELECT licenca FROM cadsys;";

                string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    {
                        {
                            NpgsqlCommand command = new NpgsqlCommand(comandolistabd, conn);
                            NpgsqlDataReader dr = command.ExecuteReader();

                            while (dr.Read())
                            {

                            }
                        }
                        {
                            conn.Close();
                            cbxListaBD.SelectedIndex = 0;
                        }
                    }
                }
                catch
                {
                }

                {
                    String dumpCommand = "set PGUSER=postgres" + " \r\n" + "set PGPASSWORD=pg@atualDev" + "\r\n" + pgDumpPath + " -i " + "-h " + host + " -p " + port + " -U " + user + " -d " + database + " -v " + arquivo; //+" \r\n" + "pause"
                    String passFileContent = " " + host + " : " + port + " : " + database + " : " + user + " : " + password + "";

                    String batFilePath = System.IO.Path.Combine(
                        System.IO.Path.GetTempPath(),
                        Guid.NewGuid().ToString() + ".bat");

                    try
                    {
                        String batchContent = "";
                        batchContent += dumpCommand;

                        File.WriteAllText(
                            batFilePath,
                            batchContent,
                            Encoding.ASCII);

                        ProcessStartInfo oInfo = new ProcessStartInfo(batFilePath);
                        oInfo.UseShellExecute = false;
                        oInfo.CreateNoWindow = true;

                        using (Process proc = System.Diagnostics.Process.Start(oInfo))
                        {
                            proc.WaitForExit();
                            proc.Close();
                        }
                    }
                    finally
                    {
                        if (File.Exists(batFilePath))
                            File.Delete(batFilePath);
                        System.Windows.Forms.MessageBox.Show("Restauração Concluída com sucesso", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    try
                    {
                        string selectcadsys = "SELECT licenca FROM cadsys;";
                        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                        conn.Open();
                        {
                            {
                                {
                                    NpgsqlCommand command = new NpgsqlCommand(selectcadsys, conn);
                                    NpgsqlDataReader dr = command.ExecuteReader();
                                    DataTable dt = new DataTable();
                                    dt.Load(dr);
                                    txtEmpresaBD.Text = (dr["licenca"].ToString());
                                    //lblListaBD.DisplayMemberPath = "licenca";
                                    //lblListaBD.Items.Add(dt);
                                    lblEmpresaBD.Visibility = Visibility.Visible;
                                    txtEmpresaBD.Visibility = Visibility.Visible;
                                    //lblListaBD.Visibility = Visibility.Visible;
                                }
                            }
                            {
                                conn.Close();
                            }
                        }
                    }

                    catch
                    {

                    }
                }
            }


        }

        private void gridTeste_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {          
            
        }
        private void gridTeste_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
             //gridTeste.Background = new SolidColorBrush(Colors.Green);
        }
        // // // // // // // // // // // // // // // // // // 
        private void gridRenomeiaBD_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //  gridRenomeiaBD.Background = new SolidColorBrush(Colors.Silver);            
        }
        private void gridRenomeiaBD_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //  gridRenomeiaBD.Background = new SolidColorBrush(Colors.Green);
        }
        // // // // // // // // // // // // // // // // // // 
        private void gridCriaBD_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //  gridCriaBD.Background = new SolidColorBrush(Colors.Silver);
        }
        private void gridCriaBD_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //  gridCriaBD.Background = new SolidColorBrush(Colors.Green);
        }
        // // // // // // // // // // // // // // // // // // 
        private void gridRestore_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //  gridRestore.Background = new SolidColorBrush(Colors.Silver);
        }
        private void gridRestore_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // gridRestore.Background = new SolidColorBrush(Colors.Green);
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            string local = @"C:\VDF7\Integra\Programs\";
            string arquivo = "ExportaSQL.exe";

            try
            {
                if (Directory.Exists(local) == true)
                {
                    if (File.Exists(local + arquivo) == false)
                    {
                        string urlArquivo = "http://www.atualsistemas.net/ftp/Integra/ExportaSQL.exe";
                        string caminhoArquivo = local + arquivo;
                        WebClient client = new WebClient();
                        client.DownloadFile(urlArquivo, caminhoArquivo);
                    }

                    if (File.Exists(local + arquivo) == true)
                    {
                        if (System.Windows.Forms.MessageBox.Show("Arquivo " + arquivo + " já existe na pasta!!\nDeseja fazer o download novamente??", "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            string urlArquivo = "http://www.atualsistemas.net/ftp/Integra/ExportaSQL.exe";
                            string caminhoArquivo = local + arquivo;
                            WebClient client = new WebClient();
                            client.DownloadFile(urlArquivo, caminhoArquivo);
                        }
                    }
                }
            }
            catch
            {

            }
            // // // // // // // // // // // // // // // // // // 

        }

        private void txtSenhalistaBD_PasswordChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtSenhalistaBD.Password.Trim() == "abd1179jc")

                {
                    btnListarBD.IsEnabled = true;
                    btnRenomearBD.IsEnabled = true;
                    btnRestore.IsEnabled = true;
                    btnCriarBD.IsEnabled = true;
                    btnCriausuario.IsEnabled = true;
                }
                else
                {
                    btnListarBD.IsEnabled = false;
                    btnRenomearBD.IsEnabled = false;
                    btnRestore.IsEnabled = false;
                    btnCriarBD.IsEnabled = false;
                    btnCriausuario.IsEnabled = false;

                }
            }
            catch
            {

            }
        }

        private void btnCriausuario_Click(object sender, RoutedEventArgs e)
        {
            if (rbSenhaPadrao.IsChecked == true)
            {
                string serverbd = txtServer.Text;
                string portabd = txtPorta.Text;
                string userpadrao = "postgres";
                string senhapadrao = "pg@atualDev";
                string bdsqlpadrao = "postgres";


                string connectionString = "Server=" + serverbd + "; Port=" + portabd + "; UserID=" + userpadrao + "; password=" + senhapadrao + "; Database=" + bdsqlpadrao + ";";
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    {
                        NpgsqlCommand command = new NpgsqlCommand("do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'atualsistemas') THEN CREATE ROLE atualsistemas WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'F3cH@d0S'; END IF; END $$;" +
                            "do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'desenvolvedor') THEN CREATE ROLE desenvolvedor WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@acessoDev'; END IF; END $$;" +
                            "do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'consultor') THEN CREATE ROLE consultor WITH LOGIN NOSUPERUSER NOCREATEDB NOCREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'abd1179jcInov'; END IF; END $$;" +
                            "ALTER ROLE postgres WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@atualDev';" +
                            "ALTER ROLE atualsistemas WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'F3cH@d0S';" +
                            "ALTER ROLE desenvolvedor WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@acessoDev';" +
                            "ALTER ROLE consultor WITH LOGIN NOSUPERUSER NOCREATEDB NOCREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'abd1179jcInov';", conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            int i;
                            for (i = 0; i < dr.FieldCount; i++)
                            {
                                Console.Write("{0} \t", dr[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                    {

                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Usuários criados com Sucesso!!", "Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Usuários NÂO foram criados!!\nProvavelmente a mude a opção para senha de instalação e digite a senha que utilizou para instalar no campo 'Senha de Instalação'!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (rbSenhainstala.IsChecked == true)
            {

                string serverbd2 = txtServer.Text;
                string portabd2 = txtPorta.Text;
                string userpadrao2 = "postgres";
                string bdsqlpadrao2 = "integrapgsql";
                string senhainstalacao = txtSenhapostgre.Password;

                string connectionString2 = "Server=" + serverbd2 + "; Port=" + portabd2 + "; UserID=" + userpadrao2 + "; password=" + senhainstalacao + "; Database=" + bdsqlpadrao2 + ";";
                try
                {
                    NpgsqlConnection conn2 = new NpgsqlConnection(connectionString2);
                    conn2.Open();
                    {
                        NpgsqlCommand command2 = new NpgsqlCommand("do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'atualsistemas') THEN CREATE ROLE atualsistemas WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'F3cH@d0S'; END IF; END $$;" +
                            "do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'desenvolvedor') THEN CREATE ROLE desenvolvedor WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@acessoDev'; END IF; END $$;" +
                            "do $$ BEGIN IF NOT EXISTS ( SELECT * FROM   pg_catalog.pg_user WHERE  usename = 'consultor') THEN CREATE ROLE consultor WITH LOGIN NOSUPERUSER NOCREATEDB NOCREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'abd1179jcInov'; END IF; END $$;" +
                            "ALTER ROLE postgres WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@atualDev';" +
                            "ALTER ROLE atualsistemas WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'F3cH@d0S';" +
                            "ALTER ROLE desenvolvedor WITH LOGIN SUPERUSER CREATEDB CREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'pg@acessoDev';" +
                            "ALTER ROLE consultor WITH LOGIN NOSUPERUSER NOCREATEDB NOCREATEROLE INHERIT REPLICATION CONNECTION LIMIT -1 ENCRYPTED PASSWORD 'abd1179jcInov';", conn2);
                        NpgsqlDataReader dr2 = command2.ExecuteReader();
                        while (dr2.Read())
                        {
                            int i;
                            for (i = 0; i < dr2.FieldCount; i++)
                            {
                                Console.Write("{0} \t", dr2[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                    {

                        conn2.Close();
                        System.Windows.Forms.MessageBox.Show("Usuários criados com Sucesso!!", "Confirmação!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Usuários NÂO foram criados!!\nProvavelmente a mude a opção para senha de padrão e tente novamente!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}



