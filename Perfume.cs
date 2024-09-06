public class Perfume{
    public static string[] PerfumeNovo(){
    Console.WriteLine("Qual O Nome Do Perfume?");
    string nome = Console.ReadLine();

    Console.WriteLine("Qual A Descrição ?");
    string desc = Console.ReadLine();

    Console.WriteLine("Qual A Marca Do Perfume?");
    string marca = Console.ReadLine();

    Console.WriteLine("Qual o Preço do Perfume?");
    string preco = Console.ReadLine();

    Console.WriteLine("Quantos Perfumes Tem em estoque?");
    string estoque = Console.ReadLine();

    Console.WriteLine("Qual a cor do frasco?");
    string cor = Console.ReadLine();

    string [] Lista = new string[] { nome, desc, marca, preco, estoque, cor };
    return Lista;
    }    
}