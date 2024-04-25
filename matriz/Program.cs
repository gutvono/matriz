int qtd_linha = 0, qtd_coluna = 0, menorNumero = 0, maiorNumero = 0, sinal = 0, erroSinal = 0, calculoPronto = 0, restart = 0;
int[,] matriz1, matriz2, matriz3;


//FUNCOES
//ESTA FUNCAO CRIA AS MATRIZES E AS IMPRIME NA TELA
void criarMatrizes(int linhas, int colunas, int menorN, int maiorN)
{
    matriz1 = new int[linhas, colunas];
    matriz2 = new int[linhas, colunas];
    matriz3 = new int[linhas, colunas];

    Console.WriteLine("MATRIZ 1:");
    for (int l = 0; l < linhas; l++)
    {
        if (l > 0) Console.WriteLine();
        for (int c = 0; c < colunas; c++)
        {
            matriz1[l, c] = new Random().Next(menorN, maiorN);
            Console.Write(matriz1[l, c] + " ");
        }
    };

    Console.WriteLine();

    Console.WriteLine("MATRIZ 2");
    for (int l = 0; l < linhas; l++)
    {
        if (l > 0) Console.WriteLine();
        for (int c = 0; c < colunas; c++)
        {
            matriz2[l, c] = new Random().Next(menorN, maiorN);
            Console.Write(matriz2[l, c] + " ");
        }
    };
}

void calcularMatriz(string mensagem, int sinal, int[,] primeiraMatriz, int[,] segundaMatriz)
{
    if (calculoPronto == 1) return;

    for (int l = 0; l < qtd_linha; l++)
    {
        if (l > 0) Console.WriteLine();
        for (int c = 0; c < qtd_coluna; c++)
        {
            switch (sinal)
            {
                case 1:
                    matriz3[l, c] = primeiraMatriz[l, c] + segundaMatriz[l, c];
                    Console.Write(matriz3[l, c] + " ");
                    break;
                case 2:
                    matriz3[l, c] = primeiraMatriz[l, c] - segundaMatriz[l, c];
                    Console.Write(matriz3[l, c] + " ");
                    break;
                case 3:
                    matriz3[l, c] = primeiraMatriz[l, c] * segundaMatriz[l, c];
                    Console.Write(matriz3[l, c] + " ");
                    break;
                case 4:
                    matriz3[l, c] = primeiraMatriz[l, c] / segundaMatriz[l, c];
                    Console.Write(matriz3[l, c] + " ");
                    break;
                case 5:
                    matriz3[l, c] = primeiraMatriz[l, c] % segundaMatriz[l, c];
                    Console.Write(matriz3[l, c] + " ");
                    break;
            }
        }
    }
    calculoPronto = 1;
}

//INICIO DA INTERACAO COM O USUARIO
do
{
    Console.Clear();
    //CRIANDO AS MATRIZES ORIGINAIS
    Console.Write("\nInforme a quantidade de LINHAS das matrizes: ");
    qtd_linha = int.Parse(Console.ReadLine());

    Console.Write("\nInforme a quantidade de COLUNAS das matrizes: ");
    qtd_coluna = int.Parse(Console.ReadLine());

    Console.Write("\nInforme qual será o MENOR número que terá nas matrizes: ");
    menorNumero = int.Parse(Console.ReadLine());

    Console.Write("\nInforme qual será o MAIOR número que terá nas matrizes: ");
    maiorNumero = int.Parse(Console.ReadLine());

    Console.WriteLine("Matrizes ORIGINAIS:");
    criarMatrizes(qtd_linha, qtd_coluna, menorNumero, maiorNumero);
    Console.WriteLine();

    do
    {
        if (erroSinal == 1) Console.WriteLine("\nERRO: Favor informar o sinal corretamente:");

        Console.WriteLine("Qual operação deseja realizar?");
        Console.WriteLine("1 - SOMAR;");
        Console.WriteLine("2 - SUBTRAIR;");
        Console.WriteLine("3 - MULTIPLICAR;");
        Console.WriteLine("4 - DIVIDIR;");
        Console.WriteLine("5 - RESTO;");
        sinal = int.Parse(Console.ReadLine());
    } while (sinal < 1 || sinal > 5);
    erroSinal = 0;

    Console.WriteLine();

    //OPERAÇÕES
    calcularMatriz("\n\nSOMA: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nSUBTRAÇÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nMULTIPLICAÇÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nDIVISÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nRESTOS DA DIVISÃO: ", sinal, matriz1, matriz2);

    Console.WriteLine("\n\nReiniciar programa?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("0 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);