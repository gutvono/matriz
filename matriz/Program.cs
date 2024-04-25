using System;

int qtd_linha = 0, qtd_coluna = 0, menorNumero = 0, maiorNumero = 0, sinal = 0, erroSinal = 0, calculoPronto = 0, restart = 0;
int[,] matriz1, matriz2, matriz3;


//FUNCOES
void menu()
{
    //CRIANDO AS MATRIZES ORIGINAIS
    Console.Write("\nInforme a quantidade de LINHAS das matrizes: ");
    qtd_linha = int.Parse(Console.ReadLine());

    Console.Write("\nInforme a quantidade de COLUNAS das matrizes: ");
    qtd_coluna = int.Parse(Console.ReadLine());

    //POPULANDO MATRIZ
    Console.Write("\nInforme qual será o MENOR número que terá nas matrizes: ");
    menorNumero = int.Parse(Console.ReadLine());

    Console.Write("\nInforme qual será o MAIOR número que terá nas matrizes: ");
    maiorNumero = int.Parse(Console.ReadLine());

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
}


//ESTA FUNCAO CRIA AS MATRIZES E AS IMPRIME NA TELA
void criarMatrizes(int linhas, int colunas)
{
    matriz1 = new int[linhas, colunas];
    matriz2 = new int[linhas, colunas];
    matriz3 = new int[linhas, colunas];

    Console.WriteLine();
}

void popularMatrizes(int[,] matriz, int min, int max)
{
    for (int l = 0; l < qtd_linha; l++)
    {
        if (l > 0) Console.WriteLine();
        for (int c = 0; c < qtd_coluna; c++)
        {
            matriz[l, c] = new Random().Next(min, max);
            Console.Write(matriz[l, c] + " ");
        }
    };

    Console.WriteLine();
}

void calcularMatriz(string mensagem, int sinal, int[,] primeiraMatriz, int[,] segundaMatriz)
{
    if (calculoPronto == 1) return;

    Console.WriteLine(mensagem);
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

do
{
    Console.Clear();

    //INICIO DA INTERACAO COM O USUARIO
    menu();

    //CRIAR MATRIZES
    Console.WriteLine("Matrizes ORIGINAIS:");
    criarMatrizes(qtd_linha, qtd_coluna);
    Console.WriteLine();

    //POPULAR MATRIZES
    Console.WriteLine("MATRIZ 1:");
    popularMatrizes(matriz1, menorNumero, maiorNumero);

    Console.WriteLine("\nMATRIZ 2:");
    popularMatrizes(matriz2, menorNumero, maiorNumero);

    //REALIZAR O CALCULO
    calcularMatriz("\n\nRESULTADO SOMA: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nRESULTADO SUBTRAÇÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nRESULTADO MULTIPLICAÇÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nRESULTADO DIVISÃO: ", sinal, matriz1, matriz2);

    calcularMatriz("\n\nRESULTADO RESTOS DA DIVISÃO: ", sinal, matriz1, matriz2);

    Console.WriteLine("\n\nReiniciar programa?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);