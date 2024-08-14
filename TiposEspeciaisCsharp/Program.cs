using TiposEspeciaisDotnet.Models;
using Newtonsoft.Json;

string arquivoJson = File.ReadAllText("C:\\Users\\Admin\\Desktop\\projects\\Csharp-Study\\TiposEspeciaisCsharp\\TiposEspeciaisCsharp\\Files\\vendas.json");
List<Vendas> listVendas = JsonConvert.DeserializeObject<List<Vendas>>(arquivoJson);

foreach(Vendas venda in listVendas)
{
    Console.WriteLine($"\nid: {venda.Id}\nProduto: {venda.NomeProduto}\nPreço: {venda.Preco} " +
        $"\nData: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}\n" +
        $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
}