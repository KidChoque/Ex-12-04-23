// // 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// // menor valor lido.

int[] numero =new int[10];

for (var i = 0; i < numero.Length ; i++)
{
    Console.WriteLine($"Digitew um número");
    numero[i] = int.Parse(Console.ReadLine());
     
    
}

int maior = 0;
int menor = 0;

for (var i = 0; i < numero.Length; i++)
{
    if ( i == 0)
{
    maior = numero[0];
    menor = numero[0];
}
else if( numero[i] > maior )
{
 maior = numero[i];       
}
else if( numero[i] < menor)
{
    menor = numero[i];
}
}

Console.WriteLine($"menor número = {menor}");
Console.WriteLine($"maior número = {maior}");

