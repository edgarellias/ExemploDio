using ConsoleExplorando.Models;
using Newtonsoft.Json;
using System.IO;





























//var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "buta", Altura = 1.80 };









//string conteudoArquivo = File.ReadAllText("E:/temp/vendas.json");

//List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//foreach(Venda venda in listaVenda)
//{
//    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda}, Desconto: {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
//}









































//DateTime dataAtual = DateTime.Now;

//List<Venda> listaVendas = new List<Venda>();

//Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Software", 110.00M, dataAtual);

//listaVendas.Add(v1);
//listaVendas.Add(v2);

//string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

//File.WriteAllText("E:/temp/vendas.json", serializado);

//Console.WriteLine(serializado);






































//int numero = 15;
//bool ehPar = false;

//ehPar = numero % 2 == 0;

//Console.WriteLine($"O Número {numero} é " + (ehPar ? "par" : "impar"));




































//(int, string, string, decimal) tupla = (1, "Edgar", "Elias", 10.5M);


//Console.WriteLine($"Id: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");
















//Queue<int> fila = new Queue<int>();
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);

//foreach(int i in fila)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($"Removendo o Elemento: {fila.Dequeue()}");

//fila.Enqueue(10);
//foreach (int i in fila)
//{
//    Console.WriteLine(i);
//}









































//new ExemploExcecao().Metodo1();


//try
//{



//    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//} catch(Exception ex)
//{
//    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
//}


























//using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");











//string numero1 = "10";
//string numero2 = "20";

//string resultado = numero1+ numero2;

//Console.WriteLine(resultado);
























//Pessoa p1 = new Pessoa("Edgar", "Elias");
//Pessoa p2 = new Pessoa("Eduardo", "Neves queiroz");

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();
//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();
