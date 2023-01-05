using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thot_v3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string conteudo = "";

            try
            {
                corre();     
                conteudo = pesquisarConteudo(txtPesquisar.Text);
                criarArquivo(conteudo);
             }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                throw;
            }
        }

        private void criarArquivo(String conteudo)
        {
            throw new NotImplementedException();
        }

        private String pesquisarConteudo(string conteudo)
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
