// // 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// // declarado.

int[] numeros = { 10, 12, 7, 1, 4 };

Array.Sort(numeros);

foreach (var n in numeros)
{
    Console.Write($"{n} ");
}