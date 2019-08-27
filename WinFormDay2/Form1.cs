using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDay2.Services;

namespace WinFormDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caminhoPasta = new FolderBrowserDialog();
            caminhoPasta.ShowDialog();
            txtCaminhoArq.Text = caminhoPasta.SelectedPath;
        }

        private void BtnEnviarRelatorio_Click(object sender, EventArgs e)
        {
            ExcelService exService = new ExcelService();
            EmailService emService = new EmailService();
            try
            {
                var anexo = exService.GerarPlanilha(txtCaminhoArq.Text);
                emService.SendEmail(txtEmailDestinario.Text, txtAssunto.Text,
                    txtMensagem.Text, anexo);
            }
            catch
            {
                MessageBox.Show("Algo deu errado. T-T ");
            }

            finally
            {
                MessageBox.Show("Relatório enviado com sucesso! ^-^");
                txtMensagem.Text = "";
                txtAssunto.Text = "";
                txtCaminhoArq.Text = "";
                txtEmailDestinario.Text = "";
            }

            

        }
    }
}
