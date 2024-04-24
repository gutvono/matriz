int qtd_linhas = 5, qtd_colunas = 5;
int[,] matriz1 = new int[qtd_linhas, qtd_colunas];
int[,] matriz2 = new int[qtd_linhas, qtd_colunas];
int[,] matriz3 = new int[qtd_linhas, qtd_colunas];

//CRIANDO A MATRIZ ORIGINAL
Console.WriteLine("Matriz ORIGINAL 1:");
for (int l = 0; l < qtd_linhas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz1[l, c] = new Random().Next(1, 10);
        Console.Write(matriz1[l, c] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("Matriz ORIGINAL 2:");
for (int l = 0; l < qtd_linhas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz2[l, c] = new Random().Next(1, 10);
        Console.Write(matriz2[l, c] + " ");
    }
}
Console.WriteLine();

//OPERAÇÕES
Console.WriteLine("\nSOMA:");
for (int l = 0;l < qtd_colunas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0;c < qtd_colunas; c++)
    {
        matriz3[l, c] = matriz1[l, c] + matriz2[l, c];
        Console.Write(matriz3[l, c] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("\nSUBTRAÇÃO:");
for (int l = 0; l < qtd_colunas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz3[l, c] = matriz1[l, c] - matriz2[l, c];
        Console.Write(matriz3[l, c] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("\nMULTIPLICAÇÃO:");
for (int l = 0; l < qtd_colunas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz3[l, c] = matriz1[l, c] * matriz2[l, c];
        Console.Write(matriz3[l, c] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("\nDIVISÃO:");
for (int l = 0; l < qtd_colunas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz3[l, c] = matriz1[l, c] / matriz2[l, c];
        Console.Write(matriz3[l, c] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("\nRESTOS DA MATRIZ DE DIVISÃO:");
for (int l = 0; l < qtd_colunas; l++)
{
    if (l > 0) Console.WriteLine();
    for (int c = 0; c < qtd_colunas; c++)
    {
        matriz3[l, c] = matriz1[l, c] % matriz2[l, c];
        Console.Write(matriz3[l, c] + " ");
    }
}
Console.WriteLine();