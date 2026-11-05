using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_Desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "NEON Logo";
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
███╗   ██╗███████╗ ██████╗ ███╗   ██╗
████╗  ██║██╔════╝██╔═══██╗████╗  ██║
██╔██╗ ██║█████╗  ██║   ██║██╔██╗ ██║
██║╚██╗██║██╔══╝  ██║   ██║██║╚██╗██║
██║ ╚████║███████╗╚██████╔╝██║ ╚████║
╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚═╝  ╚═══╝
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.ReadKey();
            Console.Clear();


            Console.Title = "Jornada do Runner";
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Ano 2067.
Uma cidade nunca adormece.
Luzes de néon iluminam ruas molhadas pela chuva, enquanto drones vigiam os céus.
Grandes sistemas digitais controlam o mundo, e o código tornou-se poder.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Tu és um Runner.
Alguém que aprende programação para sobreviver, decidir e enfrentar sistemas complexos.
Cada linha de código que escreves é uma ação.
Cada desafio resolvido é um passo em frente.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Prepara-te para explorar, experimentar e criar.
A programação começa aqui.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Clique em qualquer tecla...");

            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Runner gostarias de entrar nesta desafiadora jornada de programação?
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
(S)-SIM
(N)-NÃO
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Ótima escolha! Vamos começar.");
                    Thread.Sleep(2000);
                    break;
                }
                else if (tecla.Key == ConsoleKey.N)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Que pena! Tens a certeza que não queres?
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
(T)-TENHO CERTEZA
(Q)-QUERO
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        ConsoleKeyInfo teclaConfirmacao = Console.ReadKey(true);

                        if (teclaConfirmacao.Key == ConsoleKey.Q)
                        {
                            Console.WriteLine("Boa! Sabia que mudarias de ideia.");
                            break;
                        }
                        else if (teclaConfirmacao.Key == ConsoleKey.T)
                        {
                            Console.WriteLine("Ok, desligando sistemas...");
                            Thread.Sleep(2000);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Erro! Tenta novamente.");
                            Thread.Sleep(2000);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tenta novamente.");
                    Thread.Sleep(2000);
                }
            }

            Console.Clear();
            bool jogar = true;
            while (jogar)
            {
                Console.WriteLine(@"
━━━━━━━━━━━━MENU━━━━━━━━━━━━
(1) - Começar Jornada
(2) - Objetivo do Jogo
(3) - Sair
━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine(@"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Vamos começar a jornada, Runner.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Thread.Sleep(2000);
                    break;
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━OBJETIVO DO JOGO━━━━━━━━━━━━━━━━━━━━
• Avançar pelas fases superando obstáculos. 
• Derrotar inimigos e evitar armadilhas. 
• Coletar itens para aumentar sua pontuação. 
• Sobreviver o máximo possível para alcançar o recorde. 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("A sair... Até breve!");
                    jogar = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                    Console.ReadKey();
                }

            }

            int pontos = 0;
            Random rnd = new Random();


            // DESAFIO 1 – Adivinha

            string resposta1 = "";
            while (resposta1.ToLower() != "idade")
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 1 – Adivinha da Cidade 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Um drone projeta uma pergunta no ar:
'O que sobe, mas nunca desce?'
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                resposta1 = Console.ReadLine();

                if (resposta1.ToLower() == "idade")
                {
                    Console.WriteLine("Sistema: Resposta correta. +1 ponto.");
                    pontos++;
                }
                else
                {
                    Console.WriteLine("Errado. O drone aguarda nova tentativa...");
                    Console.ReadKey();
                }
            }


            // DESAFIO 2 – Conta 

            bool acertou2 = false;
            while (!acertou2)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 2 – Terminal de Cálculo 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.Write("Primeiro número: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Segundo número: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Operação (+ ou -): ");
                string opera = Console.ReadLine();

                int resultado = 0;
                bool valido = true;

                if (opera == "+") resultado = n1 + n2;
                else if (opera == "-") resultado = n1 - n2;
                else valido = false;

                if (!valido)
                {
                    Console.WriteLine("Operação inválida.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Resultado: ");
                int resp = Convert.ToInt32(Console.ReadLine());

                if (resp == resultado)
                {
                    Console.WriteLine("Acesso concedido. +1 ponto.");
                    pontos++;
                    acertou2 = true;
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("Código incorreto. O terminal reinicia...");
                    Console.ReadKey();
                }
            }


            // DESAFIO 3 – Número Maior

            bool acertou3 = false;
            while (!acertou3)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 3 – Comparador de Dados 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.Write("Primeiro número: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Segundo número: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine($"{a} é maior que {b}. +1 ponto.");
                    pontos++;
                    acertou3 = true;
                    Thread.Sleep(2000);
                    break;
                }
                else if (b > a)
                {
                    Console.WriteLine($"{b} é maior que {a}. +1 ponto.");
                    pontos++;
                    acertou3 = true;
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Os números são iguais. O sistema exige diferença.");
                    Console.ReadKey();
                }
            }


            // DESAFIO 4 – Contar Números 

            bool acertou4 = false;
            while (!acertou4)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 4 – Contador de Pacotes 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.Write("Introduz um número inteiro positivo: ");
                int limite = Convert.ToInt32(Console.ReadLine());

                if (limite <= 0)
                {
                    Console.WriteLine("Valor inválido.");
                    Console.ReadKey();
                    continue;
                }

                for (int nengue = 1; nengue <= limite; nengue++)
                {
                    Console.WriteLine(nengue);
                }

                Console.WriteLine("Fluxo exibido. +1 ponto.");
                pontos++;
                acertou4 = true;
            }


            // DESAFIO 5 – Adivinha Aleatória 

            string[] adivinhas = {
    "Sou o lugar onde escreves o teu código. O que sou?(Oq é o Visual Studio)",
    "Sou a coisa mais comum de acontecer com um programa em desenvolvimento. O que sou?(é quase impossivel não acontecer)",
    "Sou o comando usado para repetir algo várias vezes. O que sou?(Ciclo em ingles)"
};

            string[] respostas = { "compilador", "erro", "loop" };

            bool acertou5 = false;
            while (!acertou5)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 5 – Enigma Aleatório 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                int id = rnd.Next(adivinhas.Length);
                Console.WriteLine(adivinhas[id]);

                string resp = Console.ReadLine().ToLower();

                if (resp == respostas[id])
                {
                    Console.WriteLine("Enigma decifrado. +1 ponto.");
                    pontos++;
                    acertou5 = true;
                }
                else
                {
                    Console.WriteLine("Errado. O servidor envia outro enigma...");
                    Console.ReadKey();
                }
            }


            // DESAFIO 6 – Qual é o Mês? 

            string[] meses = {
    "Janeiro","Fevereiro","Março","Abril",
    "Maio","Junho","Julho","Agosto",
    "Setembro","Outubro","Novembro","Dezembro"
};

            bool acertou6 = false;
            while (!acertou6)
            {
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 6 – Calendário 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.Write("Introduz um número (1 a 12): ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num >= 1 && num <= 12)
                {
                    Console.WriteLine($"Mês correspondente: {meses[num - 1]}. +1 ponto.");
                    pontos++;
                    acertou6 = true;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                    Console.ReadKey();
                }
            }


            // DESAFIO 7 – Jogo da Forca 

            string palavra = "banana";
            char[] progresso = { '_', '_', '_', '_', '_', '_' };
            int erros = 0;

            while (erros < 6 && new string(progresso) != palavra)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 7 – Forca 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Dica 1: É uma comida.
Dica 2: É amarela.
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.WriteLine($"Palavra: {string.Join(" ", progresso)}");
                Console.Write("Letra: ");
                char letra = Console.ReadLine().ToLower()[0];

                if (palavra.Contains(letra))
                {
                    for (int nengue = 0; nengue < palavra.Length; nengue++)
                        if (palavra[nengue] == letra)
                            progresso[nengue] = letra;
                }
                else
                {
                    erros++;
                    Console.WriteLine($"Erro {erros}/6");
                    Console.ReadKey();
                }
            }

            if (new string(progresso) == palavra)
            {
                Console.WriteLine("Palavra completa! +1 ponto.");
                pontos++;
            }
            else
            {
                Console.WriteLine("Falhaste o desafio.");
            }


            // DESAFIO 8 – Roleta 

            string[] cores = { "Vermelho", "Dourado", "Azul-Bebe" };
            bool continuarRole = true;

            while (continuarRole)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 8 – Roleta 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                string c1 = cores[rnd.Next(3)];
                string c2 = cores[rnd.Next(3)];
                string c3 = cores[rnd.Next(3)];

                Console.WriteLine($"{c1} | {c2} | {c3}");

                if (c1 == c2 && c2 == c3)
                {
                    Console.WriteLine("Três cores iguais! +1 ponto.");
                    pontos++;
                    continuarRole = false;
                }
                else
                {
                    Console.Write("Tentar novamente? (s/n): ");
                    if (Console.ReadLine().ToLower() != "s")
                        continuarRole = false;
                }
            }


            // DESAFIO 9 – Calculadora 

            bool calc = true;
            while (calc)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 9 – Calculadora 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
1 - Adição
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Sair
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                int opera2 = Convert.ToInt32(Console.ReadLine());
                if (opera2 == 5) break;

                Console.Write("Número 1: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Número 2: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double r = 0;

                if (opera2 == 1) r = x + y;
                else if (opera2 == 2) r = x - y;
                else if (opera2 == 3) r = x * y;
                else if (opera2 == 4) r = x / y;

                Console.WriteLine($"Resultado: {r}");
                Console.ReadKey();
            }

            Console.WriteLine("Calculadora concluída. +1 ponto.");
            pontos++;


            // DESAFIO 10 – Contador de Vogais 

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 10 – Contador de Vogais
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            Console.Write("Escreve uma frase: ");
            string frase = Console.ReadLine().ToLower();

            int vogais = 0;
            foreach (char c in frase)
                if ("aeiou".Contains(c))
                    vogais++;

            Console.WriteLine($"A frase tem {vogais} vogais.");
            Console.WriteLine(" +1 ponto.");
            Console.ReadKey();
            pontos++;


            // DESAFIO 11 – Jogo dos Dados 

            bool jogarDados = true;
            while (jogarDados)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 11 – Dados 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                int d1 = rnd.Next(1, 7);
                int d2 = rnd.Next(1, 7);

                Console.WriteLine($"Dado 1: {d1}");
                Console.WriteLine($"Dado 2: {d2}");
                Console.WriteLine($"Soma: {d1 + d2}");

                Console.Write("Jogar novamente? (s/n): ");
                if (Console.ReadLine().ToLower() != "s")
                    jogarDados = false;
            }

            Console.WriteLine("+1 ponto.");
            pontos++;


            // DESAFIO 12 – Mini Quiz 

            string[] perguntas = {
    "Em que ano se passa este jogo?(2000 + meme famoso)",
    "Como se chama o jogador?(corredor em inglês)",
    "Qual é o poder mais valioso neste mundo?(os programadores utilizam muito)"
};

            string[] respostasQuiz = {
    "2067",
    "runner",
    "codigo"
};

            int certas = 0;

            for (int nengue = 0; nengue < perguntas.Length; nengue++)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 12 – Mini Quiz 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.WriteLine(perguntas[nengue]);
                string rQuiz = Console.ReadLine().ToLower();

                if (rQuiz == respostasQuiz[nengue])
                    certas++;
            }

            Console.WriteLine($"Acertaste {certas}/3.");
            Console.WriteLine("+1 ponto.");
            pontos++;
            Console.ReadKey();


            // DESAFIO 13 – Anagrama 

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 13 – Anagrama 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            string palavraCorreta = "SigmaBoy";
            string embaralhada = "igmaSyoB";

            Console.WriteLine($"Desembaralha: {embaralhada}");
            string tentativa = Console.ReadLine().ToLower();

            if (tentativa == palavraCorreta)
            {
                Console.WriteLine(" Correto! +1 ponto.");
                pontos++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Errado.");

            }


            // DESAFIO 14 – Tabuleiro 

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 14 – Tabuleiro 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            string[,] tab = new string[3, 3];

            for (int nengue = 0; nengue < 3; nengue++)
                for (int POIS = 0; POIS < 3; POIS++)
                    tab[nengue, POIS] = "_";

            Console.Write("Linha (0-2): ");
            int lin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coluna (0-2): ");
            int col = Convert.ToInt32(Console.ReadLine());

            tab[lin, col] = "X";

            for (int nengue = 0; nengue < 3; nengue++)
            {
                for (int pois = 0; pois < 3; pois++)
                    Console.Write(tab[nengue, pois] + " ");
                Console.WriteLine();
                Console.ReadKey();
            }

            Console.WriteLine("+1 ponto.");
            pontos++;

            // DESAFIO 15 – Adivinha o Número 

            int secreto = rnd.Next(1, 51);
            int palpite = 0;

            while (palpite != secreto)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 15 – Adivinha o Número 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
O sistema escolheu um número entre 1 e 50.
Tenta adivinhar...
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                palpite = Convert.ToInt32(Console.ReadLine());

                if (palpite > secreto)
                    Console.WriteLine("O sistema indica: MENOR.");
                else if (palpite < secreto)
                    Console.WriteLine("O sistema indica: MAIOR.");
                else
                {
                    Console.WriteLine(" Acertaste! +1 ponto.");
                    pontos++;
                }

                Console.ReadKey();
            }


            // DESAFIO 16 – Adivinha o Som Eletrónico

            string[] sons = { "bip bop", "piu piu", "bzz bzz" };
            string[] objetos = { "robot", "laser", "drone" };

            int Som = rnd.Next(sons.Length);
            bool acertou16 = false;

            while (!acertou16)
            {
                Console.Clear();
                Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 16 – Adivinha o Som Eletrónico
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
O sistema reproduz um som digitalizado:
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                Console.WriteLine($"Som: {sons[Som]}");
                Console.Write("O som pertence a quê? ");

                string resposta = Console.ReadLine().ToLower();

                if (resposta == objetos[Som])
                {
                    Console.WriteLine(" Correto! +1 ponto.");
                    pontos++;
                    acertou16 = true;
                }
                else
                {
                    Console.WriteLine("Errado. Tenta novamente...");
                    Console.ReadKey();
                }

                Console.ReadKey();
            }


            // DESAFIO 17 – Tradutor de Emojis 

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 17 – Tradutor de Emojis 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Palavras disponíveis:
amor → ❤️
sol → ☀️
chocolate → 🍫
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            Console.Write("Escreve uma frase: ");
            string fraseEmoji = Console.ReadLine().ToLower();

            fraseEmoji = fraseEmoji.Replace("amor", "❤️");
            fraseEmoji = fraseEmoji.Replace("sol", "☀️");
            fraseEmoji = fraseEmoji.Replace("chocolate", "🍫");

            Console.WriteLine("Tradução NEON:");
            Console.WriteLine(fraseEmoji);

            Console.WriteLine("+1 ponto.");
            pontos++;
            Console.ReadKey();

            // DESAFIO 18 – Anedota Aleatória 

            string[] anedotas = {
    "Porque é que o computador foi ao médico? Porque tinha um vírus!",
    "O programador foi ao bar e pediu 1 cerveja. Depois pediu 10. Depois 100...",
    "Qual é o cúmulo do programador? Ter medo de bugs!",
    "Porque é que o robo não contou a piada? Porque não tinha humor.exe",
    "O que diz um byte ao outro? 'Estou cheio!'"
};

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 18 – Anedota 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            int Anedota = rnd.Next(anedotas.Length);
            Console.WriteLine(anedotas[Anedota]);

            Console.WriteLine("+1 ponto.");
            pontos++;
            Console.ReadKey();


            // DESAFIO 19 – Desculpas 

            string[] quem = { "O meu drone", "A minha IA doméstica", "O meu robô de limpeza" };
            string[] oque = { "apagou o trabalho", "corrompeu o ficheiro", "reiniciou o sistema" };
            string[] quando = { "ontem à noite", "durante a tempestade digital", "enquanto eu dormia" };

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 19 – Desculpas 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            string desculpa = $"{quem[rnd.Next(quem.Length)]} {oque[rnd.Next(oque.Length)]} {quando[rnd.Next(quando.Length)]}.";
            Console.WriteLine(desculpa);

            Console.WriteLine("+1 ponto.");
            pontos++;
            Console.ReadKey();


            // DESAFIO 20 – Simulador de Meteoro 

            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
DESAFIO 20 – Meteoro 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Um meteoro digital cai do céu ...
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            for (int nengue = 0; nengue < 10; nengue++)
            {
                Console.Clear();
                for (int petisco = 0; petisco < nengue; petisco++)
                    Console.WriteLine();

                Console.WriteLine("        ☄️");
                Thread.Sleep(200);
            }

            Console.WriteLine(" ☄️ O meteoro colidiu com o solo digital!");
            Console.WriteLine("+1 ponto.");
            pontos++;
            Console.ReadKey();

            // FINAL 
            Console.Clear();
            Console.WriteLine(@"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
FIM DA JORNADA 
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            Console.WriteLine($"PONTUAÇÃO FINAL: {pontos} / 20");

            if (pontos == 20)
            {
                Console.WriteLine(@"
✔ Concluíste todos os desafios.
✔ Dominaste o Reino do Código.
✔ Tornaste-te um PROGRAMADOR INICIADO EM NEON.");
            }
            else
            {
                Console.WriteLine("Ainda tens desafios por dominar, Runner...");
            }

            Console.WriteLine("Obrigado por jogar.");

        }
    }
}
