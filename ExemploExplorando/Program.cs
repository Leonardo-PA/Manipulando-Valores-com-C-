using Exemploexplorando.Models;
using System.Globalization;


// Metodo de Datetime com Tryparse e validação do retorno do tryparse
string dataString = "2024-10-15 21:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data );//tryparse, vai tentar converter essa represetnação de data, para um tipo date time uma data valida com a qual ele consiga trabalhar.

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso!  Data: {data}");
}

else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}


//Fomatação de data e de hora com tipo DateTime
DateTime data = DateTime.Parse(dataString);
Console.WriteLine(data);

Console.WriteLine(data.ToLongTimeString());//para expor só a hora
Console.WriteLine(data.ToShortDateString());//para apresentar somente a data
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//se colocar ele em minusculo ele represente os minutos, então cuidado com os maiculos e minusculos



// //Formatação de cultura dentro do codigo, alteração e localização e cultura do codigo
 CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//alterando a formatação de acordo com a cultura do sistema inserido Dolar("en-US")

 decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("C8"));// C currence e o numero, quantidade de casa decimal. pode ser substituido por N também.
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//outra maneira de realizar a alteração da cultura
// //Console.WriteLine($"{valorMonetario:C}");//quando temos a interpolação e colocamos: significa que eu quero formatar ela o C significa corrence(Moeda), 


//representando porcentagem: 
 double porcentagem = .3421;

 Console.WriteLine(porcentagem.ToString("P"));//usado o metodo de double pode se representar porcentagens no meu terminal

 int numero = 123456;
 Console.WriteLine(numero.ToString("##-##-##"));//nesse metodo pode se apresentar difernetes tipos de formatos das representações,meotdo personalizado que pode ser usado.



//Parte de manipulação de valores.:

 int numero1 = 10; // mesmo sendo do tipo inteiro por conta do + no meu resultado (concatenação) ele sempre vai ser lido como uma string
 string numero2 = "20";

 string resultado = numero1 + numero2;

 Console.WriteLine(resultado);



 Pessoa p1 =new Pessoa(nome: "Leonardo", sobrenome: "Pereira de Andrade");
 // p1.Nome = "leonardo";
 // p1.Sobrenome = "pereira de andrade";

 Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz"); //está susbistuindo usando um construtor e para os parametros, porém justificar sempre.
 // p2.Nome = "Eduardo";
 // p2.Sobrenome = "Neves Queiroz";

 Curso cursoDeIngles = new Curso();
 cursoDeIngles.Nome = "Ingles";
 cursoDeIngles.Alunos = new List<Pessoa>();

 cursoDeIngles.AdicionarAluno(p1);
 cursoDeIngles.AdicionarAluno(p2);
 cursoDeIngles.ListarAlunos();


 Pessoa p1 = new Pessoa();   //Nesse caso estamos estanciando uma variavel e salvando ela de forma que assuma o lugar de P1
 p1.Nome= "leonardo";
 p1.Sobrenome = "pereira de andrade";
 p1.Idade = 24;  //colocou valor de igual está atribuindo um SET 
 p1.Apresentar();    //não inseriu o valor de = então estão atribuindo o GET

 //quando fazemos isso com P1 significa que estamos atriubuindo ao meu p1 um valor de propriedade como idade ou nome



