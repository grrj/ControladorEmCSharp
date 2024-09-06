using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PTI
{
    public class Program{
        static void Main(string[] args)
        { 
            int cont =  0;
            string[,] produtos = new string[0, 6];

            NovoProduto novo = new NovoProduto();
            
            ModificaProduto modifica = new ModificaProduto();

            Menu menu = new Menu();
            int entrada;
            
            Perfume item = new Perfume();
            
            
            do{
                entrada = menu.Display();
                switch (entrada)
                {
                    case 1:
                        string[] novoProduto = Perfume.PerfumeNovo();
                        produtos = NovoProduto.AdicionarProduto(produtos, novoProduto, ref cont);
                        break;
                    case 2:
                         if (cont > 0)
                    {
                        Console.WriteLine("Lista de Produtos:");
                        for (int i = 0; i < cont; i++)
                        {
                            Console.WriteLine($"Nome: {produtos[i, 0]}, Descrição: {produtos[i, 1]}, Marca: {produtos[i, 2]}, Preço: {produtos[i, 3]}, Estoque: {produtos[i, 4]}, Cor: {produtos[i, 5]}");
                        }
                    }
                        else
                        {
                            Console.WriteLine("Lista Vazia!");
                        }
                        break;
                    case 3:
                    case 4:
                    case 5:
                        produtos = ModificaProduto.ModificarProduto(produtos,ref cont, entrada);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }} while (entrada != 6); 
            
            }
        }
    }
