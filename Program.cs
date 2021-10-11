using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SAIDA DE DADOS *
 
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            /* ENTRADA DE DADOS *

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /* EXERCICIOS 01 LUCAS *

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entra com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Minha casa tem: " + quartos + " quartos");
            Console.WriteLine("O preço do produto é: " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine(a);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* EXERCICIO LUCAS 02 */

            /* Aqui eu declaro todas as variaveis que vou usar para pegar dados *
            double largura, comprimento, precoMetroQuadrado, area, preco;

            /* Aqui ja sao as variaveis solicitando a entrada de dados para o usuario digitar *
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* Aqui as operações matematicas para realizar o calculo *
            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            /* Imprimindo na tela o resultado de AREA e PRECO *
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* PRIMEIRO EXERCICIO URI JUDGE 1001 *

            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);

            */

            /* EXERCICIO URI JUDGE 1002 - AREA DO CIRCULO *

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             A = pi * R * R;

             Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
             */

            /* EXERCICIO URI JUDGE 1003 - SOMA SIMPLES *

            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);    
            
            */

            /* EXERCICIO URI JUDGE 1004 - PRODUTO SIMPLES *

            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine(PROD);

            */

            /* EXERCICIO URI JUDGE 1005 - MEDIA 1 *

           double A, B, media;

           A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           media = ((A * 3.5) + (B * 7.5)) / 11;

           Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

           */

            /* EXERCICIO URI JUDGE 1006 - MEDIA 2 *

            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

             */

            /* EXERCICIO URI JUDGE 1007 - DIFERENÇA *

            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = ((A * B) - (C * D));

            Console.WriteLine("DIFERENCA = " + diferenca);

            */

            /* EXERCICIO URI JUDGE 1008 - SALARIO *

            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* EXERCICIO URI JUDGE 1009 - SALARIO COM BONUS *

            double salarioFixo, totalVenda, salarioTotal;
            
            string nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* EXERCICIO URI JUDGE 1010 - CALCULO SIMPLES *

            int codigoPeca1, codigoPeca2, numeroPecas1, numeroPecas2;
            double valorPeca1, valorPeca2, valorTotal1, valorTotal2, aPagar;

            string[] v = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(v[0]);
            numeroPecas1 = int.Parse(v[1]);
            valorPeca1 = double.Parse(v[2], CultureInfo.InvariantCulture);


            valorTotal1 = numeroPecas1 * valorPeca1;
                       

            string[] v2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(v2[0]);
            numeroPecas2 = int.Parse(v2[1]);
            valorPeca2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

            valorTotal2 = numeroPecas2 * valorPeca2;

            aPagar = valorTotal1 + valorTotal2;

            Console.WriteLine("VALOR A PAGAR: R$ " + aPagar.ToString("F2", CultureInfo.InvariantCulture));

            */

            /* EXERCICIO URI JUDGE 1011 - ESFERA *

            double r, pi = 3.14159, volume;

            r = double.Parse(Console.ReadLine());
            volume = (4 / 3.0) * pi * (r * r * r);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            */

            /* EXERCICIO URI JUDGE 1012 


            /* EXERCICIO URI JUDGE 1014 - CONSUMO VEICULAR *

            int distanciaTotalPercorrida;
            double totalCombustivelGasto, consumoMedio;

            distanciaTotalPercorrida = int.Parse(Console.ReadLine());
            totalCombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distanciaTotalPercorrida / totalCombustivelGasto;
            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            */

            /* EXERCICIO URI JUDGE 1016 - DISTANCIA *

            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");

            */

            /* EXERCICIO URI JUDGE 1017 - GASTO DE COMBUSTIVEL *

            double tempoGasto, velocidadeMedia, distanciaPercorrida, litrosNecessarios;

            tempoGasto = double.Parse(Console.ReadLine());
            velocidadeMedia = double.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGasto * velocidadeMedia;
            litrosNecessarios = distanciaPercorrida / 12;

            Console.WriteLine(litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture));

            */

        }
    }
}
