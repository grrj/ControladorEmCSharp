class ModificaProduto
{
    public static string[,] ModificarProduto(string[,] produtos, ref int cont, int entrada)
    {
        switch (entrada)
        {
            case 3:
                Console.WriteLine("Digite a posição do produto que quer remover:");
                int seletorRemover = int.Parse(Console.ReadLine());

                if (seletorRemover < 0 || seletorRemover >= cont)
                {
                    Console.WriteLine("Posição inválida!");
                    return produtos;
                }

                // Cria um novo array com uma linha a menos
                string[,] novoArrayRemover = new string[cont - 1, 6];

                // Copia os elementos do array antigo para o novo, exceto o que será removido
                int novoIndiceRemover = 0;
                for (int i = 0; i < cont; i++)
                {
                    if (i == seletorRemover) continue; // Pula o item que será removido

                    for (int j = 0; j < 6; j++)
                    {
                        novoArrayRemover[novoIndiceRemover, j] = produtos[i, j];
                    }
                    novoIndiceRemover++;
                }
                cont--;
                return novoArrayRemover; // Retorna o novo array com o produto removido

            case 4:
            case 5:
                Console.WriteLine("Digite a posição do produto:");
                int seletorEstoque = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite quantos perfumes entrarão/saíram do estoque:");
                int quantidade = int.Parse(Console.ReadLine());

                if (seletorEstoque < 0 || seletorEstoque >= cont)
                {
                    Console.WriteLine("Posição inválida!");
                    return produtos;
                }

                // Atualiza o estoque do produto selecionado
                int estoqueAtual = int.Parse(produtos[seletorEstoque, 4]); // Posição 4 é o estoque
                if (entrada == 4)
                {
                    estoqueAtual += quantidade; // Adiciona a quantidade ao estoque
                }
                else if (entrada == 5)
                {
                    estoqueAtual -= quantidade; // Remove a quantidade do estoque
                }
                produtos[seletorEstoque, 4] = estoqueAtual.ToString(); // Atualiza o valor no array

                Console.WriteLine("Estoque atualizado com sucesso!");
                return produtos; // Retorna o array com o estoque atualizado
            default:
                Console.WriteLine("Opção invalida");
                return produtos;
        }
    }
}