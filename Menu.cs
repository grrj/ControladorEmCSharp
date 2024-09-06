
public class Menu(){
    public int Display(){
    Console.WriteLine(" [1] Novo\n [2] Listar Produtos\n [3] Remover Produtos\n [4] Entrada Estoque\n [5] Saída Estoque\n [6] Sair");
    Console.WriteLine("Digite o numero do menu que deseja entrar");
    return int.Parse(Console.ReadLine());
    }
}