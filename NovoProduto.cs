using System.Globalization;

class NovoProduto
{
    public static string[,] AdicionarProduto(string[,] produtos, string[] novoProduto, ref int cont)
    {
        // Cria um novo array com uma linha a mais
        string[,] novoArray = new string[cont + 1, 6];

        // Copia os elementos do array antigo para o novo
        for (int i = 0; i < cont; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                novoArray[i, j] = produtos[i, j];
            }
        }

        // Adiciona o novo produto na última linha do novo array
        for (int j = 0; j < 6; j++)
        {
            novoArray[cont, j] = novoProduto[j];
        }

        // Incrementa o contador
        cont++;

        return novoArray;
    }
}
