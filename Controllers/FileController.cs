using Examples_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Examples_MVC.Controllers
{
    public class FileController : Controller
    {
        public FileController()
        {
            
        }

        public IActionResult Index()
        {
            return View(GetClients());
        }

        private static List<Client> GetClients()
        {
            return
            [
                new Client("Lucas", 18, "Masculino"),
                new Client("Thais", 28, "Feminino"),
                new Client("Suellen", 80, "Feminino"),
                new Client("Teste", 55, "Masculino"),
                new Client("Fagner", 77, "Masculino"),
                new Client("Luis", 25, "Masculino"),
            ];
        }

        [HttpPost]
        public async Task<FileResult> Exportar(int id)
        {
            var clients = GetClients();

            // Define os nomes das colunas no arquivo CSV
            var columnNames = new string[] { "Name", "Age", "Gender"};
            var sb = new StringBuilder();

            // Adiciona o cabeçalho ao CSV
            sb.AppendLine(string.Join(";", columnNames));

            // Percorre a lista de clientes e constrói o CSV
            foreach (var client in clients)
            {
                // Cria um array com os dados do cliente que serão inseridos no CSV
                var clientData = new string[] 
                {
                    client.Name,
                    client.Age.ToString(),
                    client.Gender
                };

                // Adiciona os dados do cliente ao StringBuilder, separados por vírgula
                sb.AppendLine(string.Join(";", clientData));
            }

            // Converte o StringBuilder para array de bytes e retorna como arquivo CSV
            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "Clientes.csv");
        }
    }
}
