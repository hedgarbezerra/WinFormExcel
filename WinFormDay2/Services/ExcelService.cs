using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormDay2.Models;

namespace WinFormDay2.Services
{
    public class ExcelService
    {
        private BankDbContext db = new BankDbContext();
        public string GerarPlanilha(string caminhoArq)
        {
            var clientes = db.Clientes.ToList();

            string nomeSheet = "Relatorio"+DateTime.Now.ToString("dd-MM-yyyy");

            var workBook = new XLWorkbook();
            var worksheet = workBook.Worksheets.Add(nomeSheet);

            worksheet.Cell("A1").Value = "Nome";
            worksheet.Cell("B1").Value = "CPF";
            worksheet.Cell("C1").Value = "Numero";

            int linha = 2;

            foreach (Cliente item in clientes)
            {
                worksheet.Cell("A" + linha.ToString()).Value = item.Nome;
                worksheet.Cell("B" + linha.ToString()).Value= item.Cpf;
                var conta = db.Contas.Where(c => c.IdCliente == item.Id).FirstOrDefault();

                if (conta != null)
                {
                    worksheet.Cell("C" + linha.ToString()).Value = conta.Numero;
                }

                linha++;
            }
            string caminhoFinal = caminhoArq+ "\\" + nomeSheet +".xlsx";

            workBook.SaveAs(caminhoFinal);
            workBook.Dispose();

            return caminhoFinal;
        
        }
    }
}
