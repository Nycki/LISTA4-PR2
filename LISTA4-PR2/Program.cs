using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lista3_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- falso, pois a variavel int nao recebe numero que possuem numero após a virgula. a variavel inteira nao consegue guardar uma do tipo float mas uma variavel do tipo float consegue guardar uma do tipo int. para fazer essa converção ultilizamos o seguinte codigo:
            //numero= float.parse(console.readline());



            //2- tanto o console.readline() quanto o console.read() são ultilizados na leitura de variaveis, porem o readline le a linha de codiogo inteira retornado o numero dado e o read le apenas um caracter e retorna em ascii.



            //int x;
            //Console.WriteLine("numero");
            //x = Console.Read();



            //Console.WriteLine(x);
            //Console.ReadKey();



            //3- quando o usuario precisa entrar com valores numericos de forma em que se adquem as variaveis, a variavel int é para numeros inteiros, a variavel float é para numeros que possuem uma casa depois da virgula e a variavel tipo double mostra duas casa ou mais.



            //4-



            //int num, num2, num3;
            //Console.WriteLine("entre com o numero");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("mensagem 1");
            //else
            //    Console.WriteLine("mensagem 2");



            //Console.ReadKey();



            //caso entrar com 8 ou 27 sera emitido a mensagem 2 e se entrar com 28 sera emitido a mensagem 1
            //serve para fazer uma erificação atraves do numero para enviar determinada mensagem



            //5-
            //float s, so, v, t;



            //Console.WriteLine("qual a posição inicial? ");
            //so= float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o instante? ");
            //t= float.Parse(Console.ReadLine());
            //Console.WriteLine("qual a velocidade? ");
            //v= float.Parse(Console.ReadLine());



            //s = so + v * t;



            //Console.WriteLine("a posição final sera de: "+s);



            //Console.ReadKey();



            //6-

            //int num;

            //Console.WriteLine("qual o numero desejado:");
            //num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //    Console.WriteLine("o numero é divisivel por 3,5 e 10");
            //else if (num % 3 == 0 && num % 5 == 0 && num % 10 != 0)
            //{

            //    Console.WriteLine("o numero é divisivel por 3 e 5 ");
            //}
            //else if (num % 3 == 0 && num % 5 != 0 && num % 10 != 0)
            //{

            //    Console.WriteLine("o numero é divisivel apenas por 3");
            //}
            //else if (num % 3 != 0 && num % 5 == 0 && num % 10 != 0)
            //{

            //    Console.WriteLine("o numero é divisivel apenas por 5");

            //}

            //7-

            //int tempo, km;

            //Console.WriteLine("Sua casa fica no km:");
            //km = int.Parse(Console.ReadLine());

            //if (km >= 0 && km < 12)
            //{
            //    tempo = 71;
            //}
            //else if (km >= 12 && km < 29)
            //{
            //    tempo = 57;
            //}
            //else if (km >= 29 && km < 55)
            //{
            //    tempo = 30;
            //}
            //else if (km >= 55 && km < 82)
            //{
            //    tempo = 27;
            //}
            //else if (km >= 82 && km <= 100)
            //{
            //    tempo = 12;
            //}
            //else
            //{
            //    Console.WriteLine("Valor inválido para km");
            //    return;
            //}

            //Console.WriteLine("Você irá demorar " + tempo + " minutos para chegar à escola.");

            //Console.ReadKey();



            //8-

            //double marc, quant, result, custo, imposto, final, lucro;

            //Console.WriteLine("MARCAS");
            //Console.WriteLine("1-ROYAL");
            //Console.WriteLine("2-WISKAS");
            //Console.WriteLine("3-GOLDEN");
            //Console.WriteLine("4-NUTRIEN");
            //Console.WriteLine("5-SPECIALCAT");
            //Console.WriteLine("6-MARBA");
            //Console.WriteLine("7-GATUS");

            //Console.WriteLine("escolha uma marca:");
            //marc = double.Parse(Console.ReadLine());
            //Console.WriteLine("escolha a quantidade de unidades");
            //quant = double.Parse(Console.ReadLine());

            //switch (marc)
            //{

            //    case 1:
            //        result = 129.50 * quant;
            //        custo = result * 0.775;
            //        final = result - custo;
            //        imposto = final * 0.33;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 2:
            //        result = 182.78 * quant;
            //        custo = result * 0.897;
            //        final = result - custo;
            //        imposto = final * 0.275;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 3:
            //        result = 159.46 * quant;
            //        custo = result * 0.717;
            //        final = result - custo;
            //        imposto = final * 0.225;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 4:
            //        result = 144.80 * quant;
            //        custo = result * 0.889;
            //        final = result - custo;
            //        imposto = final * 0.25;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 5:
            //        result = 205.40 * quant;
            //        custo = result * 0.8324;
            //        final = result - custo;
            //        imposto = final * 0.22;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 7:
            //        result = 133.99 * quant;
            //        custo = result * 0.946;
            //        final = result - custo;
            //        imposto = final * 0.20;
            //        lucro = (result - final) - imposto;

            //        break;
            //    case 6:
            //        result = 125.10 * quant;
            //        custo = result * 0.904;
            //        final = result - custo;
            //        imposto = final * 0.179;
            //        lucro = (result - final) - imposto;

            //        break;
            //}

            //Console.WriteLine($"O custo do produto é: "+custo);
            //Console.WriteLine($"O imposto do produto é: "+imposto);
            //Console.WriteLine($"O lucro do produto é: "+lucro);
            //Console.WriteLine($"O preço final do produto é: "+final);
            //Console.ReadKey();

        }
    }
}