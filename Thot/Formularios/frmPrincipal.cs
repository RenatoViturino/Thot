using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Windows.Forms;


namespace Thot
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            string conteudo = copiaConteudo;
            try
            {
             
                corre();
                PesquisarConteudo(txtPesquisar.Text);
                
                criarArquivo( conteudo);


            }
            catch (Exception a)
            {
                Console.WriteLine("Erro no " + a.Message);
                throw;
            }
        }

       
        

        public String PesquisarConteudo(string conteudo)
        {
            string google = "http://www.google.com.br/";
            IWebDriver drive = new ChromeDriver();
            IWebElement campoPesquisa;
            IWebElement botaoIr;
            IWebElement clicarLink;
            IWebElement copiarConteudo;
           
            try
            {
                
                drive.Navigate().GoToUrl(google);
                campoPesquisa = drive.FindElement(By.Id("lst-ib"));
                campoPesquisa.SendKeys(txtPesquisar.Text);

                System.Threading.Thread.Sleep(25);
                
                botaoIr = drive.FindElement(By.Name("btnK"));
            
                botaoIr.Click();


                System.Threading.Thread.Sleep(25);
               clicarLink = drive.FindElement(By.ClassName("LC20lb"));
                 clicarLink.Click();

                copiarConteudo = drive.FindElement(By.TagName("body"));
                System.Threading.Thread.Sleep(2500);

                copiarConteudo.SendKeys(OpenQA.Selenium.Keys.Control + "a");
                
               


            return copiarConteudo.ToString();
            }
            catch (NoSuchElementException q)
            {

                Console.WriteLine("Erro no " + q.Message);
                throw;
            }
        }


        private void corre()
        {
            try
            {
                lblPorcentagem.Text = "0";
                prgPesquisar.Value = 0;

                while (prgPesquisar.Value < 100)
                {

                    prgPesquisar.Increment(1);
                    lblPorcentagem.Text = prgPesquisar.Value.ToString();
                    lblInfo.Text = "Carregando pesquisa";

                }

                timer1.Stop();
                lblInfo.Text = "Carregado";


            }
            catch (Exception g)
            {
                Console.WriteLine("Erro no " + g.Message);
            }
        }

        private void criarArquivo( String conteudo)
        {
            try
            {

                if (string.IsNullOrEmpty(conteudo))
                {
                    MessageBox.Show("Informe algo na caixa de texto",caption:"Digite um texto");
                    return;

                }


                salvarArquivo.Title = "Salvar Arquivo ";

                salvarArquivo.Filter = "Text File|.txt";

                salvarArquivo.FilterIndex = 0;

                salvarArquivo.FileName = "TCC_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");

                salvarArquivo.DefaultExt = ".txt";

                lblInfo.Text = "Arquivo Criado";

                salvarArquivo.InitialDirectory = @"c:\dados";

                salvarArquivo.RestoreDirectory = true;


                DialogResult resultado = salvarArquivo.ShowDialog();
                Console.WriteLine("Abriu caixa de dialogo");


                if (resultado == DialogResult.OK)
                {

                    FileStream fs = new FileStream(salvarArquivo.FileName, FileMode.Create);


                    StreamWriter writer = new StreamWriter(fs);

                    writer.Write(conteudo);

                    writer.Close();
                    lblInfo.Text = "Arquivo Salvo";
                    txtPesquisar.Text = "";
                    lblInfo.Text = "Esperando a Pesquisa";
                    Console.WriteLine("arquivo criado");

                }
                else
                {

                    MessageBox.Show("Operação cancelada");
                    Console.WriteLine("Operação cancelada");
                }

            }

            catch (Exception e)
            {
                Console.WriteLine("Erro no " + e.Message);
                throw;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
