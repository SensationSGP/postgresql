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
            DateTime oldDate = new DateTime(2017, 12, 31, 00, 00, 00);
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
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnTeste_Click(object sender, RoutedEventArgs e)
        {
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
            string comandolistabd = "SELECT datname FROM pg_database WHERE datname LIKE '%int%';" ;     

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
            System.Windows.Forms.OpenFileDialog ofd1 = new System.Windows.Forms.OpenFileDialog();

            //define as propriedades do controle OpenFileDialog
            ofd1.Multiselect = true;
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
            string comandorenomeiabd = ("ALTER DATABASE \"" +  nomebdold + "\" RENAME TO  \""  + nomebd +  "\";" );
            
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
            //string pgDumpPath = @"C:\Program Files\PostgreSQL\9.4\bin\pg_restore.exe";
            //string outFile = txtLocalBD.Text.ToString();
            //string host = txtServer.Text;
            //string port = txtPorta.Text;
            //string database = "integrapgsql";
            //string user = "postgres";
            //string password = "pg@atualDev";
            //string arquivo = txtLocalBD.Text.ToString();
            //{
            //    String dumpCommand = "\"" + pgDumpPath + "\"" + " -Fc" + " -h " + host + " -p " + port + " -d " + database + " -U " + user + "";
            //    String passFileContent = "" + host + ":" + port + ":" + database + ":" + user + ":" + password + "";

            //    String batFilePath = System.IO.Path.Combine(
            //        System.IO.Path.GetTempPath(),
            //        Guid.NewGuid().ToString() + ".bat");

            //    String passFilePath = System.IO.Path.Combine(
            //        System.IO.Path.GetTempPath(),
            //        Guid.NewGuid().ToString() + ".conf");

            //    try
            //    {
            //        String batchContent = "";
            //        batchContent += "@" + "set PGPASSFILE=" + passFilePath + "\n";
            //        batchContent += "@" + dumpCommand + "  > " + "\"" + outFile + "\"" + "\n";

            //        File.WriteAllText(
            //            batFilePath,
            //            batchContent,
            //            Encoding.ASCII);

            //        File.WriteAllText(
            //            passFilePath,
            //            passFileContent,
            //            Encoding.ASCII);

            //        if (File.Exists(outFile))
            //            File.Delete(outFile);

            //        ProcessStartInfo oInfo = new ProcessStartInfo(batFilePath);
            //        oInfo.UseShellExecute = false;
            //        oInfo.CreateNoWindow = true;

            //        using (Process proc = System.Diagnostics.Process.Start(oInfo))
            //        {
            //            proc.WaitForExit();
            //            proc.Close();
            //        }
            //    }
            //    finally
            //    {
            //        if (File.Exists(batFilePath))
            //            File.Delete(batFilePath);

            //        if (File.Exists(passFilePath))
            //            File.Delete(passFilePath);
            //    }
            //}
        }

        private void gridTeste_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
           // gridTeste.Background = new SolidColorBrush(Colors.Silver);            
        }
        private void gridTeste_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
           // gridTeste.Background = new SolidColorBrush(Colors.Green);
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
        // // // // // // // // // // // // // // // // // // 

    }
}
