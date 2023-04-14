// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade = 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <= 10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else


Console.WriteLine($"Digite o nome do produto:");
string nome = Console.ReadLine();

Console.WriteLine($"digite a quantidade do produto:");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preço unitário:");
float unitario = float.Parse(Console.ReadLine());

float total = 0;


if (quantidade == 5)
{
    total = (unitario * 5) - (unitario * 5 * 0.02f);

    Console.WriteLine($"O preço com desconto será {total}");
}
else if (quantidade > 5 && quantidade <= 10)
{
    total = (unitario * quantidade) - (unitario * quantidade * 0.03f);

    Console.WriteLine($"O preço com desconto será {total}");
}
else if (quantidade > 10)
{
    total = (unitario * quantidade) - (unitario * quantidade * 0.05f);

    Console.WriteLine($"O preço com desconto será {total}");
    
}
else
{
    total = unitario * quantidade;

    Console.WriteLine($"O preço será {total}");
    
    
}








