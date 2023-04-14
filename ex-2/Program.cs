// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

static float valorDoCombustível(char tipo, float litros)
{

    const float preçoAlcool = 5.30f;
    const float preçoGasolina = 4.90f;

    float preçoComDesconto = 0;

    switch (tipo)
    {
        case 'a':
            if (tipo == 'a' && litros <= 20)
            {
                preçoComDesconto = (preçoAlcool * litros) - (preçoAlcool * 0.3f * litros);
            }
            else
            {
                preçoComDesconto = (preçoAlcool * litros) - (preçoAlcool * 0.5f * litros);
            }
            break;
        case 'g':
            if (tipo == 'g' && litros >= 20)
            {
                preçoComDesconto = (preçoGasolina * litros) - (preçoGasolina * 0.4f * litros);
            }
            else
            {
                preçoComDesconto = (preçoGasolina * litros) - (preçoGasolina * 0.6f * litros);
            }
            break;
        
       
        default:
            break;
    }

    return preçoComDesconto;
}





Console.WriteLine($"Digite o tipo de combustível. a para Álcool, g para Gasolina:");

char tipo = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quantidade de litros que deseja colocar no seu veículo:");

float litros = float.Parse(Console.ReadLine());

float precinho = valorDoCombustível(tipo , litros);

 Console.WriteLine($"O preço com desconto será {precinho}");
 


