//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite o ano atual:");
int ano = int.Parse(Console.ReadLine());


Console.WriteLine(ano);


Console.WriteLine($"Digite sua idade :");

int idade = int.Parse(Console.ReadLine());

if ( idade < 16 )
{
    Console.WriteLine($"Ainda não vota");
    
}
else
{
    Console.WriteLine($"Ja pode votar");
    
}

