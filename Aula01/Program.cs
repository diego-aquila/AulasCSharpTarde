namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string nomeCompleto = "Diego Áquila Almeida Sampaio";

            var variavalSemTipo = "Diego";

            Console.WriteLine(variavalSemTipo.GetType());

            Console.WriteLine("Digite o seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            string idadeUsuario = Console.ReadLine();




            Console.WriteLine($"Meu nome é {nomeUsuario} e a minha idade é {idadeUsuario} ");

            
        }
    }
}
