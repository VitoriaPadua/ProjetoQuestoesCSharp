using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace QuestoesCSharp
{
    // Classe Produto- questao1e2
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
    }

    //Classe Aluno- Questao28
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }

    // Classe Carro- questao34

    public class Carro
    {
        public string Marca { get; set; }
        public int Ano { get; set; }
    }

    // Classe Pessoa- Questao58
    public class Pessoa
    {
        public string Nome { get; set; }
        public void Falar()
        {
            Console.WriteLine($"{Nome} diz: Olá!");
        }
    }

    // Classe FilaAtendimento- Questao78
    class FilaAtendimento<T>
    {
        private List<T> elementos;

        public FilaAtendimento()
        {
            elementos = new List<T>();
        }

        public void Enfileirar(T elemento)
        {
            elementos.Add(elemento);
        }

        public T Desenfileirar()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            T elemento = elementos[0];
            elementos.RemoveAt(0);
            return elemento;
        }

        public T Primeiro()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            return elementos[0];
        }

        public int Tamanho()
        {
            return elementos.Count;
        }

        public bool EstaVazia()
        {
            return elementos.Count == 0;
        }
    }


    //Classe Contato- Questao95
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }

    //Classe ContaBancaria- Questao86
    class ContaBancaria
    {
        // Propriedade para o saldo
        public decimal Saldo { get; private set; }

        // Construtor da conta bancária com saldo inicial opcional
        public ContaBancaria(decimal saldoInicial = 0)
        {
            Saldo = saldoInicial;
            Console.WriteLine($"Conta criada com saldo inicial de R$ {Saldo:F2}");
        }

        // Método para realizar um depósito
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
        }

        // Método para realizar um saque
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
                ExibirSaldo();
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido!");
            }
        }

        // Método para exibir o saldo atual
        private void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }


    class Program
    {
        // Declarar produto como uma variável de classe
        static Produto produto;

        // Declarar contato como uma variável de classe
        static List<Contato> agenda = new List<Contato>();


        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de Questões:");

                Console.WriteLine("Escolha uma questão para executar:");

                Console.WriteLine("\n-- Questões 1-25: Nível Básico --");

                Console.WriteLine("1 - Criar Produto");
                Console.WriteLine("2 - Exibir valores");
                Console.WriteLine("3 - Somar dois números inteiros");
                Console.WriteLine("4 - Verificar se um número é par ou ímpar");
                Console.WriteLine("5 - Converter metros para centímetros");
                Console.WriteLine("6 - Verificar se é maior de idade");
                Console.WriteLine("7 - Calcular a área de um círculo");
                Console.WriteLine("8 - Exibir tabuada de multiplicação do número");
                Console.WriteLine("9 - Somar números de 1 a N");
                Console.WriteLine("10 - Converter Celsius para Fahrenheit");
                Console.WriteLine("11 - Verificar se uma string é nula ou vazia");
                Console.WriteLine("12 - Exibir todos os números pares entre 1 e 50");
                Console.WriteLine("13 - Retornar o maior de três números");
                Console.WriteLine("14 - Inverter uma string");
                Console.WriteLine("15 - Verificar se pode votar (ano de nascimento)");
                Console.WriteLine("16 - Verificar se um número é positivo ou negativo");
                Console.WriteLine("17 - Calcular a média de três notas");
                Console.WriteLine("18 - Contar letras 'a' em uma string");
                Console.WriteLine("19 - Imprimir números de 1 a 10 em ordem decrescente");
                Console.WriteLine("20 - Calcular soma dos quadrados de 1 a N");
                Console.WriteLine("21 - Exibir boas-vindas com nome e idade");
                Console.WriteLine("22 - Exibir o dobro e o triplo de um número");
                Console.WriteLine("23 - Retornar o último caractere de uma string");
                Console.WriteLine("24 - Converter horas em segundos");
                Console.WriteLine("25 - Verificar se um número é divisível por 3 e 5");

                Console.WriteLine("\n-- Questões 26-50: Nível Intermediário --");

                Console.WriteLine("26 - Ordenar três números");
                Console.WriteLine("27 - Calcular fatorial");
                Console.WriteLine("28 - Exibir Aluno");
                Console.WriteLine("29 - Calcular média");
                Console.WriteLine("30 - Verificar palíndromo");
                Console.WriteLine("31 - Encontrar menor número");
                Console.WriteLine("32 - Multiplicar elementos");
                Console.WriteLine("33 - Somar números ímpares");
                Console.WriteLine("34 - Exibir Carro");
                Console.WriteLine("35 - Verificar ano bissexto");
                Console.WriteLine("36 - Exibir sequência de Fibonacci");
                Console.WriteLine("37 - Substituir espaços por '_'");
                Console.WriteLine("38 - Índice do maior elemento");
                Console.WriteLine("39 - Calcular MDC");
                Console.WriteLine("40 - Contar vogais");
                Console.WriteLine("41 - Converter decimal para binário");
                Console.WriteLine("42 - Representação em palavras");
                Console.WriteLine("43 - Simular lançamento de dado");
                Console.WriteLine("44 - Calcular IMC");
                Console.WriteLine("45 - Segundo maior número");
                Console.WriteLine("46 - Inverter array");
                Console.WriteLine("47 - Somar matrizes 2x2");
                Console.WriteLine("48 - Exibir dia da semana");
                Console.WriteLine("49 - Verificar string alfanumérica");
                Console.WriteLine("50 - Calcular potência");

                Console.WriteLine("\n-- Questões 51-75: Nível Intermediário-Avançado --");

                Console.WriteLine("51 - Verificar se uma matriz é simétrica");
                Console.WriteLine("52 - Ordenar lista de nomes em ordem alfabética");
                Console.WriteLine("53 - Encontrar elemento mais frequente em um array");
                Console.WriteLine("54 - Calcular valor absoluto sem Math.Abs()");
                Console.WriteLine("55 - Implementar busca linear");
                Console.WriteLine("56 - Simular cronômetro simples");
                Console.WriteLine("57 - Contar número de palavras em uma string");
                Console.WriteLine("58 - Criar classe Pessoa com método Falar()");
                Console.WriteLine("59 - Retornar a interseção entre dois arrays");
                Console.WriteLine("60 - Converter string para maiúsculas e minúsculas alternadas");
                Console.WriteLine("61 - Função que retorna o número de caracteres únicos em uma string");
                Console.WriteLine("62 - Numeros primos");
                Console.WriteLine("63 - Numero perfeito");
                Console.WriteLine("64 - Exibir os divisores de um numero");
                Console.WriteLine("65 - Calcular transposta de uma matriz");
                Console.WriteLine("66 - Exibir horário atual continuamente");
                Console.WriteLine("67 - Simular calculadora simples");
                Console.WriteLine("68 - Converter valor monetário para extenso");
                Console.WriteLine("69 - Calcular média ponderada de notas");
                Console.WriteLine("70 - Simular caixa eletrônico para saques");
                Console.WriteLine("71 - Arrays sao iguais");
                Console.WriteLine("72 - Senha aleatoria");
                Console.WriteLine("73 - Gerar tabela de multiplicação");
                Console.WriteLine("74 - Calcula a área de um triângulo com base em três lados");
                Console.WriteLine("75 - Numeros aleatorios entre 1 e N");

                Console.WriteLine("\n-- Questões 76-100: Nível Avançado--");

                Console.WriteLine("76 - Adivinhe o número");
                Console.WriteLine("77 - Verificar dois arrays");
                Console.WriteLine("78 - Fila de Atendimento");
                Console.WriteLine("79 - Jogo de Pedra, Papel e Tesoura");
                Console.WriteLine("80 - Soma dos Dígitos de um Número");
                Console.WriteLine("81 - Números Pares");
                Console.WriteLine("82 - Média e Maior Valor");
                Console.WriteLine("83 - Ordenação de Nomes");
                Console.WriteLine("84 - Verificar se é um Palindromo");
                Console.WriteLine("85 - Menor e Maior número entre 1 e 50");
                Console.WriteLine("86 - Conta Bancária");
                Console.WriteLine("87 - Cálculo do Salário líquido");
                Console.WriteLine("88 - Conversão de Decimal para Binário");
                Console.WriteLine("89 - Média e Aprovação de Aluno");
                Console.WriteLine("90 - Soma de Elementos de uma Matriz");
                Console.WriteLine("91 - Votação");
                Console.WriteLine("92 - Múltiplos de 3 e 7");
                Console.WriteLine("93 - Cálculo de distância entre dois pontos");
                Console.WriteLine("94 - Ordenação de Números");
                Console.WriteLine("95 - Agenda de Contatos Simples");
                Console.WriteLine("96 - Exibir Números Primos entre 1 e 100");
                Console.WriteLine("97 - Tabuada de Multiplicação até 10");
                Console.WriteLine("98 - Retornar o Maior Número em uma Matriz 3x3");
                Console.WriteLine("99 - Soma dos Quadrados dos Números de 1 a N");
                Console.WriteLine("100 - Jogo da Forca");

                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    //-- Questões 1-25: Nível Básico --
                    case 1:
                        ExibirQuestao(Questao1);
                        break;
                    case 2:
                        ExibirQuestao(Questao2);
                        break;
                    case 3:
                        ExibirQuestao(Questao3);
                        break;
                    case 4:
                        ExibirQuestao(Questao4);
                        break;
                    case 5:
                        ExibirQuestao(Questao5);
                        break;
                    case 6:
                        ExibirQuestao(Questao6);
                        break;
                    case 7:
                        ExibirQuestao(Questao7);
                        break;
                    case 8:
                        ExibirQuestao(Questao8);
                        break;
                    case 9:
                        ExibirQuestao(Questao9);
                        break;
                    case 10:
                        ExibirQuestao(Questao10);
                        break;
                    case 11:
                        ExibirQuestao(Questao11);
                        break;
                    case 12:
                        ExibirQuestao(Questao12);
                        break;
                    case 13:
                        ExibirQuestao(Questao13);
                        break;
                    case 14:
                        ExibirQuestao(Questao14);
                        break;
                    case 15:
                        ExibirQuestao(Questao15);
                        break;
                    case 16:
                        ExibirQuestao(Questao16);
                        break;
                    case 17:
                        ExibirQuestao(Questao17);
                        break;
                    case 18:
                        ExibirQuestao(Questao18);
                        break;
                    case 19:
                        ExibirQuestao(Questao19);
                        break;
                    case 20:
                        ExibirQuestao(Questao20);
                        break;
                    case 21:
                        ExibirQuestao(Questao21);
                        break;
                    case 22:
                        ExibirQuestao(Questao22);
                        break;
                    case 23:
                        ExibirQuestao(Questao23);
                        break;
                    case 24:
                        ExibirQuestao(Questao24);
                        break;
                    case 25:
                        ExibirQuestao(Questao25);
                        break;

                    //-- Questões 26-50: Nível Intermediário --
                    case 26:
                        ExibirQuestao(Questao26);
                        break;
                    case 27:
                        ExibirQuestao(Questao27);
                        break;
                    case 28:
                        ExibirQuestao(Questao28);
                        break;
                    case 29:
                        ExibirQuestao(Questao29);
                        break;
                    case 30:
                        ExibirQuestao(Questao30);
                        break;
                    case 31:
                        ExibirQuestao(Questao31);
                        break;
                    case 32:
                        ExibirQuestao(Questao32);
                        break;
                    case 33:
                        ExibirQuestao(Questao33);
                        break;
                    case 34:
                        ExibirQuestao(Questao34);
                        break;
                    case 35:
                        ExibirQuestao(Questao35);
                        break;
                    case 36:
                        ExibirQuestao(Questao36);
                        break;
                    case 37:
                        ExibirQuestao(Questao37);
                        break;
                    case 38:
                        ExibirQuestao(Questao38);
                        break;
                    case 39:
                        ExibirQuestao(Questao39);
                        break;
                    case 40:
                        ExibirQuestao(Questao40);
                        break;
                    case 41:
                        ExibirQuestao(Questao41);
                        break;
                    case 42:
                        ExibirQuestao(Questao42);
                        break;
                    case 43:
                        ExibirQuestao(Questao43);
                        break;
                    case 44:
                        ExibirQuestao(Questao44);
                        break;
                    case 45:
                        ExibirQuestao(Questao45);
                        break;
                    case 46:
                        ExibirQuestao(Questao46);
                        break;
                    case 47:
                        ExibirQuestao(Questao47);
                        break;
                    case 48:
                        ExibirQuestao(Questao48);
                        break;
                    case 49:
                        ExibirQuestao(Questao49);
                        break;
                    case 50:
                        ExibirQuestao(Questao50);
                        break;

                    //-- Questões 51-75: Nível Intermediário-Avançado --
                    case 51:
                        ExibirQuestao(Questao51);
                        break;
                    case 52:
                        ExibirQuestao(Questao52);
                        break;
                    case 53:
                        ExibirQuestao(Questao53);
                        break;
                    case 54:
                        ExibirQuestao(Questao54);
                        break;
                    case 55:
                        ExibirQuestao(Questao55);
                        break;
                    case 56:
                        ExibirQuestao(Questao56);
                        break;
                    case 57:
                        ExibirQuestao(Questao57);
                        break;
                    case 58:
                        ExibirQuestao(Questao58);
                        break;
                    case 59:
                        ExibirQuestao(Questao59);
                        break;
                    case 60:
                        ExibirQuestao(Questao60);
                        break;
                    case 61:
                        ExibirQuestao(Questao61);
                        break;
                    case 62:
                        ExibirQuestao(Questao62);
                        break;
                    case 63:
                        ExibirQuestao(Questao63);
                        break;
                    case 64:
                        ExibirQuestao(Questao64);
                        break;
                    case 65:
                        ExibirQuestao(Questao65);
                        break;
                    case 66:
                        ExibirQuestao(Questao66); // Execução contínua
                        break;
                    case 67:
                        ExibirQuestao(Questao67);
                        break;
                    case 68:
                        ExibirQuestao(Questao68);
                        break;
                    case 69:
                        ExibirQuestao(Questao69);
                        break;
                    case 70:
                        ExibirQuestao(Questao70);
                        break;
                    case 71:
                        ExibirQuestao(Questao71);
                        break;
                    case 72:
                        ExibirQuestao(Questao72);
                        break;
                    case 73:
                        ExibirQuestao(Questao73);
                        break;
                    case 74:
                        ExibirQuestao(Questao74);
                        break;
                    case 75:
                        ExibirQuestao(Questao75);
                        break;


                    //-- Questões 76-100: Nível Avançado--
                    case 76:
                        ExibirQuestao(Questao76);
                        break;
                    case 77:
                        ExibirQuestao(Questao77);
                        break;
                    case 78:
                        ExibirQuestao(Questao78);
                        break;
                    case 79:
                        ExibirQuestao(Questao79);
                        break;
                    case 80:
                        ExibirQuestao(Questao80);
                        break;
                    case 81:
                        ExibirQuestao(Questao81);
                        break;
                    case 82:
                        ExibirQuestao(Questao82);
                        break;
                    case 83:
                        ExibirQuestao(Questao83);
                        break;
                    case 84:
                        ExibirQuestao(Questao84);
                        break;
                    case 85:
                        ExibirQuestao(Questao85);
                        break;
                    case 86:
                        ExibirQuestao(Questao86);
                        break;
                    case 87:
                        ExibirQuestao(Questao87);
                        break;
                    case 88:
                        ExibirQuestao(Questao88);
                        break;
                    case 89:
                        ExibirQuestao(Questao89);
                        break;
                    case 90:
                        ExibirQuestao(Questao90);
                        break;
                    case 91:
                        ExibirQuestao(Questao91);
                        break;
                    case 92:
                        ExibirQuestao(Questao92);
                        break;
                    case 93:
                        ExibirQuestao(Questao93);
                        break;
                    case 94:
                        ExibirQuestao(Questao94);
                        break;
                    case 95:
                        ExibirQuestao(Questao95);
                        break;
                    case 96:
                        ExibirQuestao(Questao96);
                        break;
                    case 97:
                        ExibirQuestao(Questao97);
                        break;
                    case 98:
                        ExibirQuestao(Questao98);
                        break;
                    case 99:
                        ExibirQuestao(Questao99);
                        break;
                    case 100:
                        ExibirQuestao(Questao100);
                        break;


                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        // Método para exibir uma questão e voltar ao menu
        static void ExibirQuestao(Action questao)
        {
            Console.Clear();
            questao();
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey();
        }



        //-- Questões 1-25: Nível Básico --

        // Questão 1: Cria um objeto Produto e exibe seus valores
        static void Questao1()
        {
            // Criação de um novo objeto Produto com atributos Nome, Preco, Cor e Marca
            produto = new Produto { Nome = "Tablet", Preco = 1500.00, Cor = "Cinza", Marca = "Samsung" };
            // Exibe o nome e o preço do produto criado
            Console.WriteLine($"Produto criado: {produto.Nome}, Preço: R$ {produto.Preco}");
        }

        // Questão 2: Verifica se o produto foi criado e exibe seus valores
        static void Questao2()
        {
            // Verifica se o objeto produto não é nulo
            if (produto != null)
            {
                // Exibe os detalhes do produto se ele foi criado
                Console.WriteLine($"Produto: {produto.Nome}, Preço: R$ {produto.Preco}, Cor:  {produto.Cor} , Marca:  {produto.Marca}");
            }
            else
            {
                // Exibe mensagem se o produto não foi criado
                Console.WriteLine("Produto não foi criado.");
            }
        }

        // Questão 3: Soma dois números inteiros e exibe o resultado
        static void Questao3()
        {
            // Solicita ao usuário para digitar o primeiro número
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            // Solicita ao usuário para digitar o segundo número
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            // Calcula a soma dos dois números
            int soma = a + b;
            // Exibe o resultado da soma
            Console.WriteLine($"A soma de {a} e {b} é: {soma}");
        }

        // Questão 4: Verifica se um número é par ou ímpar.
        static void Questao4()
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            // Verifica se o número é par ou ímpar
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par.");
            }
            else
            {
                Console.WriteLine($"{num} é ímpar.");
            }
        }

        // Questão 5: Converte um valor em metros para centímetros.
        static void Questao5()
        {
            // Solicita ao usuário para digitar um valor em metros
            Console.WriteLine("Digite o valor em metros: ");
            double metros = double.Parse(Console.ReadLine());
            // Converte metros para centímetros
            double centimetros = metros * 100;
            // Exibe o resultado da conversão
            Console.WriteLine($"{metros} metros é igual a {centimetros} centímetros.");
        }

        // Questão 6: Verifica se a idade indica maioridade.
        static void Questao6()
        {
            // Solicita ao usuário para digitar sua idade
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            // Verifica se a idade é maior ou igual a 18
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }

        // Questão 7: Calcula a área de um círculo dado o raio.
        static void Questao7()
        {
            // Solicita ao usuário para digitar o raio do círculo
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            // Calcula a área do círculo usando a fórmula A = πr²
            double area = Math.PI * Math.Pow(raio, 2);
            // Exibe o resultado da área
            Console.WriteLine($"A área do círculo é: {area}");
        }

        // Questão 8: Exibe a tabuada de multiplicação para um número.
        static void Questao8()
        {
            // Solicita ao usuário para digitar um número para a tabuada
            Console.WriteLine("Digite um número para exibir sua tabuada de x: ");
            int numero = int.Parse(Console.ReadLine());
            // Exibe a tabuada de multiplicação para o número informado
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // Questão 9: Soma os números de 1 até um valor N.
        static void Questao9()
        {
            // Solicita ao usuário para digitar um número N
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            // Calcula a soma dos números de 1 até N
            for (int i = 1; i <= N; i++)
            {
                soma += i;
            }
            // Exibe o resultado da soma
            Console.WriteLine($"A soma dos números de 1 até {N} é: {soma}");
        }

        // Questão 10: Converte uma temperatura de Celsius para Fahrenheit.
        static void Questao10()
        {
            // Solicita ao usuário para digitar a temperatura em Celsius
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            // Converte a temperatura de Celsius para Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
            // Exibe o resultado da conversão
            Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");
        }

        // Questão 11: Verifica se uma string é nula ou vazia.
        static void Questao11()
        {
            // Solicita ao usuário para digitar uma string
            Console.WriteLine("Digite uma string: ");
            string input = Console.ReadLine();
            // Verifica se a string é nula ou vazia
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("A string é nula ou vazia.");
            }
            else
            {
                Console.WriteLine("A string não é nula nem vazia.");
            }
        }

        // Questão 12: Exibe os números pares entre 1 e 50.
        static void Questao12()
        {
            // Informa ao usuário que os números pares entre 1 e 50 serão exibidos
            Console.WriteLine("Números pares entre 1 e 50:");
            // Loop para verificar e exibir números pares
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Questão 13: Identifica o maior de três números inseridos.
        static void Questao13()
        {
            // Solicita ao usuário para digitar três números
            Console.WriteLine("Digite três números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            // Usa Math.Max para encontrar o maior número entre os três
            int maior = Math.Max(num1, Math.Max(num2, num3));
            // Exibe o maior número
            Console.WriteLine($"O maior número é: {maior}");
        }

        // Questão 14: Inverte uma string e exibe o resultado.
        static void Questao14()
        {
            // Solicita ao usuário para digitar uma string
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            // Converte a string em um array de caracteres
            char[] charArray = str.ToCharArray();
            // Inverte o array de caracteres
            Array.Reverse(charArray);
            // Exibe a string invertida
            Console.WriteLine($"String invertida: {new string(charArray)}");
        }

        // Questão 15: Verifica se a idade permite votar com base no ano de nascimento.
        static void Questao15()
        {
            // Solicita ao usuário para digitar seu ano de nascimento
            Console.WriteLine("Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            // Calcula a idade com base no ano atual
            int idade = DateTime.Now.Year - anoNascimento;
            // Verifica se a idade é suficiente para votar
            if (idade >= 16)
            {
                Console.WriteLine("Você pode votar.");
            }
            else
            {
                Console.WriteLine("Você não pode votar.");
            }
        }

        // Questão 16: Verifica se um número é positivo ou negativo.
        static void Questao16()
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            // Verifica se o número é positivo ou negativo
            if (numero >= 0)
            {
                Console.WriteLine($"{numero} é positivo.");
            }
            else
            {
                Console.WriteLine($"{numero} é negativo.");
            }
        }

        // Questão 17: Calcula a média de três notas e informa se o aluno está aprovado ou reprovado.
        static void Questao17()
        {
            // Solicita ao usuário para digitar três notas
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            // Calcula a média das notas
            double media = (nota1 + nota2 + nota3) / 3;
            // Verifica se o aluno foi aprovado ou reprovado
            if (media >= 7.0)
                Console.WriteLine($"Aprovado com média: {media}");
            else
                Console.WriteLine($"Reprovado com média: {media}");
        }

        // Questão 18: Conta o número de ocorrências da letra 'a' em uma string.
        static void Questao18()
        {
            // Solicita ao usuário para digitar uma string
            Console.WriteLine("Digite uma string: ");
            string input = Console.ReadLine();
            int count = 0;
            // Conta quantas vezes a letra 'a' (ou 'A') aparece na string
            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }
            // Exibe o número de ocorrências da letra 'a'
            Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
        }

        // Questão 19: Exibe os números de 10 a 1 em ordem decrescente.
        static void Questao19()
        {
            // Informa ao usuário que os números de 10 a 1 serão exibidos
            Console.WriteLine("Números de 10 a 1 em ordem decrescente:");
            // Loop para exibir números de 10 a 1
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Questão 20: Calcula a soma dos quadrados dos números de 1 até N.
        static void Questao20()
        {
            // Solicita ao usuário para digitar um número N
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int somaQuadrados = 0;
            // Calcula a soma dos quadrados dos números de 1 até N
            for (int i = 1; i <= N; i++)
            {
                somaQuadrados += i * i;
            }
            // Exibe o resultado da soma dos quadrados
            Console.WriteLine($"A soma dos quadrados de 1 até {N} é: {somaQuadrados}");
        }

        // Questão 21: Recebe o nome e idade do usuário e exibe uma saudação.
        static void Questao21()
        {
            // Solicita ao usuário para digitar seu nome
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            // Solicita ao usuário para digitar sua idade
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            // Exibe uma saudação com o nome e idade do usuário
            Console.WriteLine($"Bem-vindo, {nome}! Você tem {idade} anos.");
        }

        // Questão 22: Exibe o dobro e o triplo de um número.
        static void Questao22()
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            // Calcula e exibe o dobro do número
            Console.WriteLine($"O dobro de {numero} é: {numero * 2}");
            // Calcula e exibe o triplo do número
            Console.WriteLine($"O triplo de {numero} é: {numero * 3}");
        }

        // Questão 23: Exibe o último caractere de uma string.
        static void Questao23()
        {
            // Solicita ao usuário para digitar uma string
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            // Obtém o último caractere da string
            char ultimoChar = str[str.Length - 1];
            // Exibe o último caractere
            Console.WriteLine($"O último caractere da string é: {ultimoChar}");
        }

        // Questão 24: Converte uma quantidade de horas em segundos.
        static void Questao24()
        {
            // Solicita ao usuário para digitar uma quantidade de horas
            Console.WriteLine("Digite a quantidade de horas: ");
            double horas = double.Parse(Console.ReadLine());
            // Converte horas em segundos
            double segundos = horas * 3600;
            // Exibe a quantidade de segundos equivalentes
            Console.WriteLine($"{horas} horas equivalem a {segundos} segundos.");
        }

        // Questão 25: Verifica se um número é divisível por 3 e por 5.
        static void Questao25()
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            // Verifica se o número é divisível por 3 e por 5
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Console.WriteLine($"{numero} é divisível por 3 e 5.");
            }
            else
            {
                Console.WriteLine($"{numero} não é divisível por 3 e 5.");
            }
        }

        //-- Questões 26-50: Nível Intermediário --

        // Questão 26: Ordena três números fornecidos
        static void Questao26()
        {
            // Solicita ao usuário para digitar três números separados por vírgula
            Console.WriteLine("Digite três números separados por vírgula:");
            var numeros = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            // Ordena a lista de números
            numeros.Sort();

            // Exibe os números em ordem crescente
            Console.WriteLine("Números em ordem crescente:");
            Console.WriteLine(string.Join(", ", numeros));
        }

        // Questão 27: Calcula o fatorial de um número
        static void Questao27()
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            // Calcula o fatorial do número
            for (int i = 2; i <= numero; i++)
                fatorial *= i;

            // Exibe o fatorial calculado
            Console.WriteLine($"Fatorial de {numero} é: {fatorial}");
        }

        // Questão 28: Classe Aluno com método para exibir Nome e Nota
        static void Questao28()
        {
            // Cria um objeto Aluno e inicializa com nome e nota
            Aluno aluno = new Aluno { Nome = "Carla", Nota = 9.5 };
            // Chama o método para exibir os dados do aluno
            aluno.Exibir();
        }

        // Questão 29: Calcula a média de uma lista de números
        static void Questao29()
        {
            // Solicita ao usuário para digitar uma lista de números separados por vírgula
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            var numeros = Console.ReadLine().Split(',').Select(double.Parse).ToList();
            // Calcula a média da lista de números
            double media = numeros.Average();

            // Exibe a média calculada
            Console.WriteLine($"A média dos números é: {media}");
        }

        // Questão 30: Verifica se uma palavra é um palíndromo
        static void Questao30()
        {
            // Solicita ao usuário para digitar uma palavra
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();
            // Inverte a palavra
            string reverso = new string(palavra.Reverse().ToArray());

            // Verifica se a palavra é um palíndromo e exibe o resultado
            Console.WriteLine(reverso.Equals(palavra, StringComparison.OrdinalIgnoreCase)
                ? "A palavra é um palíndromo."
                : "A palavra não é um palíndromo.");
        }

        // Questão 31: Encontra o menor número em um array
        static void Questao31()
        {
            // Solicita ao usuário para digitar uma lista de números separados por vírgula
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            var numeros = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            // Encontra o menor número no array
            int menor = numeros.Min();

            // Exibe o menor número encontrado
            Console.WriteLine($"O menor número é: {menor}");
        }

        // Questão 32: Multiplica todos os elementos de um array por um valor fornecido
        static void Questao32()
        {
            // Solicita ao usuário para digitar uma lista de números separados por vírgula
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            var numeros = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            // Solicita ao usuário para digitar o valor pelo qual multiplicar
            Console.WriteLine("Digite o valor pelo qual multiplicar:");
            int valor = int.Parse(Console.ReadLine());

            // Multiplica cada elemento do array pelo valor fornecido
            var multiplicados = numeros.Select(n => n * valor).ToArray();
            // Exibe o array resultante após a multiplicação
            Console.WriteLine("Array após a multiplicação:");
            Console.WriteLine(string.Join(", ", multiplicados));
        }

        // Questão 33: Retorna a soma dos números ímpares em um array
        static void Questao33()
        {
            // Solicita ao usuário para digitar uma lista de números separados por vírgula
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            var numeros = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            // Calcula a soma dos números ímpares no array
            int somaImpares = numeros.Where(n => n % 2 != 0).Sum();

            // Exibe a soma dos números ímpares
            Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
        }

        // Questão 34: Classe Carro com propriedades Marca e Ano
        static void Questao34()
        {
            // Cria um objeto Carro e inicializa com marca e ano
            Carro carro = new Carro { Marca = "BMW", Ano = 2015 };
            // Exibe as propriedades do carro
            Console.WriteLine($"Carro: Marca - {carro.Marca}, Ano - {carro.Ano}");
        }

        // Questão 35: Verifica se um ano é bissexto
        static void Questao35()
        {
            // Solicita ao usuário para digitar um ano
            Console.WriteLine("Digite um ano:");
            int ano = int.Parse(Console.ReadLine());
            // Verifica se o ano é bissexto
            bool isBissexto = DateTime.IsLeapYear(ano);

            // Exibe o resultado da verificação
            Console.WriteLine(isBissexto ? "O ano é bissexto." : "O ano não é bissexto.");
        }

        // Questão 36: Função para exibir sequência de Fibonacci
        static void Questao36()
        {
            int a = 0, b = 1, c;
            // Exibe os dois primeiros números da sequência de Fibonacci
            Console.Write("Sequência de Fibonacci: ");
            Console.Write(a + " " + b + " ");

            // Calcula e exibe os próximos números da sequência
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        // Questão 37: Função para substituir espaços em uma string por '_'
        static void Questao37()
        {
            // Solicita ao usuário para digitar uma frase
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            // Substitui os espaços por '_' na frase
            string novaFrase = frase.Replace(" ", "_");
            // Exibe a frase modificada
            Console.WriteLine("Frase modificada: " + novaFrase);
        }

        // Questão 38: Função para retornar o índice do maior elemento de um array
        static void Questao38()
        {
            // Solicita ao usuário para digitar a quantidade de números
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            // Lê os números do usuário
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Obtém o índice do maior elemento do array
            int indiceMaior = Array.IndexOf(numeros, numeros.Max());
            // Exibe o índice do maior elemento
            Console.WriteLine($"O índice do maior elemento é: {indiceMaior}");
        }

        // Questão 39: Função para calcular MDC
        static void Questao39()
        {
            // Solicita ao usuário para digitar o primeiro número
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            // Solicita ao usuário para digitar o segundo número
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            // Calcula o MDC dos dois números
            int mdc = MDC(a, b);
            // Exibe o resultado do MDC
            Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
        }

        // Função recursiva para calcular o MDC
        static int MDC(int a, int b)
        {
            return (b == 0) ? a : MDC(b, a % b);
        }

        // Questão 40: Função para contar vogais em uma string
        static void Questao40()
        {
            // Solicita ao usuário para digitar uma frase
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            // Conta o número de vogais na frase
            int vogais = frase.Count(c => "AEIOUaeiou".Contains(c));
            // Exibe a quantidade de vogais
            Console.WriteLine($"A frase possui {vogais} vogais.");
        }

        // Questão 41: Função para converter decimal para binário
        static void Questao41()
        {
            // Solicita ao usuário para digitar um número decimal
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            // Converte o número decimal para binário
            string binario = Convert.ToString(numero, 2);
            // Exibe o número em formato binário
            Console.WriteLine($"O número binário é: {binario}");
        }

        // Questão 42: Função para exibir número em palavras
        static void Questao42()
        {
            // Solicita ao usuário para digitar um número de 0 a 9
            Console.Write("Digite um número de 0 a 9: ");
            int numero = int.Parse(Console.ReadLine());

            // Array de palavras correspondentes aos números de 0 a 9
            string[] palavras = { "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };

            // Verifica se o número está no intervalo permitido e exibe a palavra correspondente
            if (numero >= 0 && numero <= 9)
                Console.WriteLine($"O número em palavras é: {palavras[numero]}");
            else
                Console.WriteLine("Número fora do intervalo.");
        }

        // Questão 43: Função para simular lançamento de dado
        static void Questao43()
        {
            Random rand = new Random();
            int[] frequencia = new int[6];

            // Simula 100 lançamentos de dado
            for (int i = 0; i < 100; i++)
            {
                int valor = rand.Next(1, 7); // Gera um número aleatório de 1 a 6
                frequencia[valor - 1]++; // Incrementa a frequência da face correspondente
            }

            // Exibe a frequência de cada face do dado
            Console.WriteLine("Frequência de cada face (em 100 lançamentos):");
            for (int i = 0; i < frequencia.Length; i++)
                Console.WriteLine($"Face {i + 1}: {frequencia[i]} vezes");
        }

        // Questão 44: Função para calcular o IMC
        static void Questao44()
        {
            // Solicita ao usuário para digitar o peso e a altura
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            // Calcula o IMC
            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            // Classificação do IMC
            string categoria;
            if (imc < 18.5)
            {
                categoria = "Baixo peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                categoria = "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                categoria = "Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                categoria = "Obesidade Grau II";
            }
            else
            {
                categoria = "Obesidade Grau III";
            }

            // Exibe a categoria do IMC
            Console.WriteLine($"Categoria: {categoria}");
        }

        // Questão 45: Função para encontrar o segundo maior número em um array
        static void Questao45()
        {
            // Solicita ao usuário para digitar a quantidade de números
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            // Lê os números do usuário
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Encontra o segundo maior número usando ordenação
            int segundoMaior = numeros.OrderByDescending(n => n).Skip(1).FirstOrDefault();
            // Exibe o segundo maior número
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");
        }

        // Questão 46: Função para inverter elementos de um array
        static void Questao46()
        {
            // Solicita ao usuário para digitar a quantidade de números
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            // Lê os números do usuário
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Inverte os elementos do array
            Array.Reverse(numeros);
            // Exibe o array invertido
            Console.WriteLine("Array invertido: " + string.Join(", ", numeros));
        }

        // Questão 47: Função para somar duas matrizes 2x2
        static void Questao47()
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] soma = new int[2, 2];

            // Lê os valores da Matriz A
            Console.WriteLine("Digite os valores da Matriz A:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Lê os valores da Matriz B
            Console.WriteLine("Digite os valores da Matriz B:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Soma as duas matrizes
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    soma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            // Exibe o resultado da soma das matrizes
            Console.WriteLine("Resultado da soma das matrizes:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Questão 48: Função para exibir dia da semana
        static void Questao48()
        {
            // Solicita ao usuário para digitar uma data
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            // Exibe o dia da semana correspondente à data
            Console.WriteLine("Dia da semana: " + data.ToString("dddd"));
        }

        // Questão 49: Função para verificar se uma string contém apenas letras e números
        static void Questao49()
        {
            // Solicita ao usuário para digitar uma string
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            // Verifica se a string não está vazia e se contém apenas letras e números
            bool isAlfanumerica = !string.IsNullOrEmpty(input) && input.All(char.IsLetterOrDigit);

            // Exibe se a string é alfanumérica
            Console.WriteLine($"A string contém apenas letras e números: {isAlfanumerica}");
        }

        // Questão 50: Função para calcular potência sem usar Math.Pow()
        static void Questao50()
        {
            // Solicita ao usuário para digitar a base e o expoente
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            // Calcula a potência usando multiplicação
            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            // Exibe o resultado da potência
            Console.WriteLine($"Resultado: {resultado}");
        }



        //-- Questões 51-75: Nível Intermediário-Avançado --

        // Questão 51: Verifica se uma matriz é simétrica
        static void Questao51()
        {
            int[,] matriz = {
        {2, 5, 11},
        {5, 4, 17},
        {11, 17, 6}
    };
            bool simetrica = true;
            // Loop para percorrer as linhas da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Loop para percorrer as colunas da matriz
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Verifica se o elemento [i,j] é igual ao elemento [j,i]
                    if (matriz[i, j] != matriz[j, i])
                    {
                        simetrica = false; // Se não for igual, não é simétrica
                        break; // Sai do loop interno
                    }
                }
            }
            // Imprime se a matriz é simétrica ou não
            Console.WriteLine(simetrica ? "A matriz é simétrica." : "A matriz não é simétrica.");
        }

        // Questão 52: Ordena uma lista de nomes em ordem alfabética
        static void Questao52()
        {
            // Lista de nomes a serem ordenados
            List<string> nomes = new List<string> { "Anna", "Lindomario", "Kayke", "Franciele", "Luan" };
            nomes.Sort(); // Ordena a lista em ordem alfabética
            Console.WriteLine("Nomes ordenados:");
            // Imprime cada nome da lista ordenada
            nomes.ForEach(Console.WriteLine);
        }

        // Questão 53: Encontrar elemento mais frequente em um array
        static void Questao53()
        {
            // Array de números a serem analisados
            int[] numeros = { 1, 3, 2, 3, 4, 3, 5, 1, 6, 1, 8 };
            // Agrupa os números e ordena para encontrar o mais frequente
            var frequente = numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            // Imprime o elemento mais frequente
            Console.WriteLine($"Elemento mais frequente: {frequente}");
        }

        // Questão 54: Calcula valor absoluto de um número sem usar Math.Abs()
        static void Questao54()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()); // Lê o número do usuário
                                                        // Calcula o valor absoluto
            int absoluto = numero < 0 ? -numero : numero;
            // Imprime o valor absoluto
            Console.WriteLine($"Valor absoluto: {absoluto}");
        }

        // Questão 55: Implementa algoritmo de busca linear
        static void Questao55()
        {
            // Array de números a serem pesquisados
            int[] array = { 5, 8, 15, 28, 44, 77, 98 };
            Console.Write("Digite o número para buscar: ");
            int numero = int.Parse(Console.ReadLine()); // Lê o número do usuário
            bool encontrado = false; // Variável para indicar se o número foi encontrado

            // Loop para percorrer o array
            for (int i = 0; i < array.Length; i++)
            {
                // Verifica se o número atual é igual ao número buscado
                if (array[i] == numero)
                {
                    encontrado = true; // Se encontrado, altera a variável
                    Console.WriteLine($"Número encontrado na posição {i}.");
                    break; // Sai do loop
                }
            }
            // Imprime se o número não foi encontrado
            if (!encontrado)
                Console.WriteLine("Número não encontrado.");
        }

        // Questão 56: Simula um cronômetro simples
        static void Questao56()
        {
            Console.WriteLine("Cronômetro iniciando... (Aperte Ctrl+C para parar)");
            int segundos = 0; // Inicializa o contador de segundos
            while (true) // Loop infinito para o cronômetro
            {
                Console.Clear(); // Limpa o console
                                 // Mostra o tempo decorrido
                Console.WriteLine($"(Aperte Ctrl+C para parar) Tempo: {segundos++} segundos");
                Thread.Sleep(1000); // Espera 1 segundo
            }
        }

        // Questão 57: Conta número de palavras em uma string
        static void Questao57()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine(); // Lê a frase do usuário
                                               // Conta o número de palavras na frase
            int palavras = frase.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            // Imprime o número de palavras
            Console.WriteLine($"Número de palavras: {palavras}");
        }

        // Questão 58: Classe Pessoa com método Falar()
        static void Questao58()
        {
            // Cria uma instância da classe Pessoa e chama o método Falar()
            Pessoa pessoa = new Pessoa { Nome = "Alice" };
            pessoa.Falar();
        }

        // Questão 59: Retorna interseção entre dois arrays
        static void Questao59()
        {
            // Dois arrays para encontrar a interseção
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 4, 5, 6, 7, 8, 9 };
            // Encontra a interseção dos arrays
            int[] intersecao = array1.Intersect(array2).ToArray();
            Console.WriteLine("Interseção entre os arrays:");
            // Imprime os elementos da interseção
            Console.WriteLine(string.Join(", ", intersecao));
        }

        // Questão 60: Converte string para maiúsculas e minúsculas alternadas
        static void Questao60()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine(); // Lê a frase do usuário
            char[] resultado = frase.ToCharArray(); // Converte a frase em um array de caracteres
                                                    // Loop para alternar entre maiúsculas e minúsculas
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = i % 2 == 0 ? char.ToUpper(resultado[i]) : char.ToLower(resultado[i]);
            }
            // Imprime a nova string formatada
            Console.WriteLine(new string(resultado));
        }

        // Questao 61: função que retorna o número de caracteres únicos em uma string.
        static void Questao61()
        {
            Console.WriteLine("Digite uma string:"); // Solicita ao usuário que digite uma string.
            string input = Console.ReadLine(); // Lê a entrada do usuário.

            int caracteresUnicos = input.Distinct().Count(); // Conta os caracteres únicos na string.
            Console.WriteLine($"Número de caracteres únicos: {caracteresUnicos}"); // Exibe o número de caracteres únicos.
        }

        // Questao 62: Numeros primos
        static void Questao62()
        {
            Console.WriteLine("Digite um número:"); // Solicita ao usuário que digite um número.
            if (int.TryParse(Console.ReadLine(), out int limite)) // Tenta converter a entrada para um número inteiro.
            {
                // Gera uma lista de números primos até o limite informado e exibe.
                Console.WriteLine($"Números primos até {limite}: {string.Join(" ", Enumerable.Range(2, limite - 1).Where(n => n > 1 && !Enumerable.Range(2, (int)Math.Sqrt(n) - 1).Any(i => n % i == 0)))}");
            }
            else
            {
                Console.WriteLine("Numero inválido."); // Exibe mensagem de erro se a entrada não for válida.
            }
        }

        // Questao 63: Numeros perfeitos
        static void Questao63()
        {
            Console.Write("Digite um número para verificar se é perfeito: "); // Solicita ao usuário um número para verificação.
            if (int.TryParse(Console.ReadLine(), out int numero)) // Tenta converter a entrada para um número inteiro.
            {
                bool resultado = EhNumeroPerfeito(numero); // Verifica se o número é perfeito.
                                                           // Exibe se o número é perfeito ou não.
                Console.WriteLine(resultado
                    ? $"{numero} é um número perfeito."
                    : $"{numero} não é um número perfeito.");
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro."); // Mensagem de erro se a entrada não for válida.
            }
        }

        // Função auxiliar para verificar se um número é perfeito.
        static bool EhNumeroPerfeito(int numero)
        {
            if (numero <= 1) return false; // Números menores ou iguais a 1 não são perfeitos.

            int soma = 0; // Inicializa a soma dos divisores.
            for (int i = 1; i <= numero / 2; i++) // Loop para encontrar divisores até a metade do número.
            {
                if (numero % i == 0) // Se i é um divisor do número.
                {
                    soma += i; // Adiciona i à soma dos divisores.
                }
            }

            return soma == numero; // Retorna true se a soma dos divisores é igual ao número.
        }

        // Questao 64: Divisores de um numero
        static void Questao64()
        {
            Console.WriteLine("Digite um número:"); // Solicita ao usuário um número.
            if (int.TryParse(Console.ReadLine(), out int numero)) // Tenta converter a entrada para um número inteiro.
            {
                // Gera e exibe os divisores do número informado.
                Console.WriteLine($"Divisores de {numero}: {string.Join(" ", Enumerable.Range(1, numero).Where(i => numero % i == 0))}");
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro."); // Mensagem de erro se a entrada não for válida.
            }
        }

        // Questão 65: Calcula a matriz transposta de uma matriz 3x3
        static void Questao65()
        {
            int[,] matriz = { // Declara uma matriz 3x3.
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

            int linhas = matriz.GetLength(0); // Obtém o número de linhas da matriz.
            int colunas = matriz.GetLength(1); // Obtém o número de colunas da matriz.
            int[,] transposta = new int[colunas, linhas]; // Inicializa a matriz transposta.

            // Preenche a matriz transposta.
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j]; // Troca as linhas por colunas.
                }
            }

            Console.WriteLine("Matriz transposta:"); // Exibe a matriz transposta.
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"{transposta[i, j]} "); // Exibe os elementos da matriz transposta.
                }
                Console.WriteLine(); // Nova linha após cada linha da matriz.
            }
        }

        // Questão 66: Exibe o horário atual continuamente até ser encerrado 
        static void Questao66()
        {
            Console.WriteLine("Pressione Ctrl+C para encerrar."); // Informa como encerrar o loop.
            while (true) // Loop infinito.
            {
                Console.Clear(); // Limpa a tela.
                Console.WriteLine($"(Aperte Ctrl+C para parar)  Horário atual: {DateTime.Now:T}"); // Exibe o horário atual.
                Thread.Sleep(1000); // Pausa por 1 segundo.
            }
        }

        // Questão 67: Calcula uma operação matemática entre dois números 
        static void Questao67()
        {
            Console.Write("Digite o primeiro número: "); // Solicita ao usuário o primeiro número.
            double numero1 = double.Parse(Console.ReadLine()); // Lê e converte a entrada para um número decimal.
            Console.Write("Digite o operador (+, -, *, /): "); // Solicita ao usuário o operador matemático.
            char operador = Console.ReadLine()[0]; // Lê o operador e armazena como um caractere.
            Console.Write("Digite o segundo número: "); // Solicita ao usuário o segundo número.
            double numero2 = double.Parse(Console.ReadLine()); // Lê e converte a entrada para um número decimal.

            // Calcula o resultado com base no operador informado.
            double resultado = operador switch
            {
                '+' => numero1 + numero2, // Soma
                '-' => numero1 - numero2, // Subtração
                '*' => numero1 * numero2, // Multiplicação
                '/' => numero2 != 0 ? numero1 / numero2 : throw new DivideByZeroException("Divisão por zero!"), // Divisão, com tratamento para divisão por zero
                _ => throw new InvalidOperationException("Operador inválido!") // Tratamento para operador inválido
            };

            Console.WriteLine($"Resultado: {resultado}"); // Exibe o resultado da operação.
        }

        // Questão 68: Converte valor monetário para uma string por extenso
        static void Questao68()
        {
            Console.Write("Digite o valor monetário (exemplo: 123.45): "); // Solicita ao usuário um valor monetário.
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e converte a entrada para um decimal.
            Console.WriteLine($"Valor por extenso: {ValorParaExtenso(valor)}"); // Converte o valor para extenso e exibe.
        }

        // Converte um valor monetário em uma string por extenso.
        static string ValorParaExtenso(decimal valor)
        {
            if (valor == 0)
                return "zero reais"; // Retorna "zero reais" se o valor for zero.

            var valorInteiro = (int)Math.Floor(valor); // Obtém a parte inteira do valor.
            var centavos = (int)((valor - valorInteiro) * 100); // Obtém os centavos do valor.

            string extenso = NumeroParaExtenso(valorInteiro) + (valorInteiro == 1 ? " real" : " reais"); // Converte a parte inteira para extenso.

            // Se houver centavos, adiciona à string de extenso.
            if (centavos > 0)
            {
                extenso += " e " + NumeroParaExtenso(centavos) + (centavos == 1 ? " centavo" : " centavos");
            }

            return extenso; // Retorna o valor por extenso.
        }

        // Converte um número inteiro em uma string por extenso.
        static string NumeroParaExtenso(int numero)
        {
            string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            if (numero == 100)
                return "cem"; // Trata o caso especial para o número 100.

            string extenso = ""; // Inicializa a string que conterá a representação por extenso.

            // Adiciona a parte das centenas, se houver.
            if (numero >= 100)
            {
                extenso += centenas[numero / 100];
                numero %= 100; // Atualiza o número para o restante após retirar as centenas.
                if (numero > 0)
                    extenso += " e "; // Adiciona "e" se ainda houver parte restante.
            }

            // Adiciona a parte das dezenas, se houver.
            if (numero >= 20)
            {
                extenso += dezenas[numero / 10];
                numero %= 10; // Atualiza o número para o restante após retirar as dezenas.
                if (numero > 0)
                    extenso += " e "; // Adiciona "e" se ainda houver parte restante.
            }

            // Adiciona a parte das unidades, se houver.
            if (numero > 0 && numero < 20)
            {
                extenso += unidades[numero];
            }

            return extenso; // Retorna o número por extenso.
        }

        // Questão 69: Calcula a média ponderada de notas e pesos 
        static void Questao69()
        {
            Console.Write("Digite a quantidade de notas: "); // Solicita ao usuário a quantidade de notas.
            int quantidade = int.Parse(Console.ReadLine()); // Lê e converte a entrada para um inteiro.
            double somaPonderada = 0, somaPesos = 0; // Inicializa as variáveis para soma ponderada e soma de pesos.

            // Loop para ler as notas e pesos.
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite a nota {i + 1}: "); // Solicita ao usuário a nota.
                double nota = double.Parse(Console.ReadLine()); // Lê e converte a entrada para um decimal.
                Console.Write($"Digite o peso da nota {i + 1}: "); // Solicita ao usuário o peso da nota.
                double peso = double.Parse(Console.ReadLine()); // Lê e converte a entrada para um decimal.

                // Atualiza as somas ponderadas e de pesos.
                somaPonderada += nota * peso;
                somaPesos += peso;
            }

            // Calcula a média ponderada se a soma de pesos for diferente de zero.
            double mediaPonderada = somaPesos != 0 ? somaPonderada / somaPesos : 0;
            Console.WriteLine($"Média ponderada: {mediaPonderada}"); // Exibe a média ponderada.
        }

        // Questão 70: Calcula a distribuição de notas para um valor de saque 
        static void Questao70()
        {
            Console.Write("Digite o valor do saque: "); // Solicita ao usuário o valor do saque.
            int valor = int.Parse(Console.ReadLine()); // Lê e converte a entrada para um inteiro.
            int[] notas = { 100, 50, 20, 10, 5, 2 }; // Define as notas disponíveis.
            Dictionary<int, int> distribuicao = new Dictionary<int, int>(); // Inicializa um dicionário para a distribuição das notas.

            // Calcula a quantidade de cada nota a ser utilizada.
            foreach (int nota in notas)
            {
                int quantidadeNotas = valor / nota; // Calcula quantas notas dessa denominação podem ser usadas.
                if (quantidadeNotas > 0) // Se houver notas a serem usadas.
                {
                    distribuicao[nota] = quantidadeNotas; // Armazena a quantidade de notas no dicionário.
                    valor %= nota; // Atualiza o valor restante.
                }
            }

            // Verifica se o valor restante é maior que zero.
            if (valor > 0)
            {
                Console.WriteLine("O valor inserido não pode ser sacado com as notas disponíveis."); // Mensagem de erro se não for possível sacar o valor.
            }
            else
            {
                Console.WriteLine("Distribuição das notas:"); // Exibe a distribuição das notas.
                foreach (var kvp in distribuicao) // Itera pelo dicionário de distribuição.
                {
                    Console.WriteLine($"{kvp.Value} nota(s) de R$ {kvp.Key}"); // Exibe a quantidade de cada nota.
                }
            }
        }

        // Questao 71: Arrays sao iguais
        static void Questao71()
        {
            string[] array1 = { "gato", "baleia", "sapo" }; // Declara o primeiro array.
            string[] array2 = { "gato", "baleia", "sapo" }; // Declara o segundo array.

            // Verifica se os arrays têm o mesmo comprimento e se todos os elementos são iguais.
            bool iguais = array1.Length == array2.Length && !array1.Where((t, i) => t != array2[i]).Any();
            Console.WriteLine(iguais ? "Os arrays são iguais." : "Os arrays não são iguais."); // Exibe se os arrays são iguais ou não.
        }

        // Questao 72: Senha aleatoria
        static void Questao72()
        {
            Console.WriteLine("Digite o comprimento da senha (max 11):"); // Solicita ao usuário o comprimento da senha.
            if (int.TryParse(Console.ReadLine(), out int comprimento) && comprimento > 0 && comprimento <= 11) // Verifica se a entrada é válida.
            {
                string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Define os caracteres possíveis para a senha.
                var senha = new HashSet<char>(); // Inicializa um conjunto para garantir que não haja caracteres duplicados.
                Random random = new Random(); // Inicializa o gerador de números aleatórios.

                // Gera a senha até atingir o comprimento desejado.
                while (senha.Count < comprimento)
                    senha.Add(caracteres[random.Next(caracteres.Length)]); // Adiciona caracteres aleatórios ao conjunto.

                Console.WriteLine($"Senha gerada: {new string(senha.ToArray())}"); // Exibe a senha gerada.
            }
        }

        // Questão 73: Gera a tabela de multiplicação para um número 
        static void Questao73()
        {
            Console.Write("Digite um número para gerar a tabela de multiplicação: "); // Solicita ao usuário um número.
            int numero = int.Parse(Console.ReadLine()); // Lê e converte a entrada para um inteiro.

            Console.WriteLine($"\nTabela de Multiplicação de {numero}:"); // Exibe o cabeçalho da tabela.
            for (int i = 1; i <= 10; i++) // Loop para gerar a tabela de multiplicação.
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}"); // Exibe cada linha da tabela.
            }
        }

        // Questão 74: Calcula a área de um triângulo a partir de seus três lados
        static void Questao74()
        {
            Console.WriteLine("Digite os lados do triângulo:"); // Solicita ao usuário os lados do triângulo.
            double lado1 = double.Parse(Console.ReadLine()); // Lê o primeiro lado.
            double lado2 = double.Parse(Console.ReadLine()); // Lê o segundo lado.
            double lado3 = double.Parse(Console.ReadLine()); // Lê o terceiro lado.

            double s = (lado1 + lado2 + lado3) / 2; // Calcula o semiperímetro do triângulo.
                                                    // Calcula a área usando a fórmula de Heron.
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

            Console.WriteLine($"A área do triângulo é: {area}"); // Exibe a área calculada.
        }

        // Questão 75: Gera números aleatórios únicos entre 1 e N
        static void Questao75()
        {
            Console.WriteLine("Digite o valor de N:"); // Solicita ao usuário o valor máximo N.
                                                       // Verifica se a entrada é um número válido e maior que zero.
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                // Gera uma lista de números de 1 a N, embaralha aleatoriamente e a converte em uma lista.
                var numeros = Enumerable.Range(1, n).OrderBy(_ => Guid.NewGuid()).ToList();
                // Exibe os números aleatórios únicos gerados.
                Console.WriteLine($"Números aleatórios únicos entre 1 e {n}: {string.Join(", ", numeros)}");
            }
        }

        //-- Questões 76-100: Nível Avançado--

        //Questao 76: Advinha o numero
        static void Questao76()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
            int tentativa = 0;
            int numeroTentativa;
            bool acertou = false;

            Console.WriteLine("Tente adivinhar o número entre 1 e 100.\n");

            // Loop do jogo
            while (!acertou)
            {
                tentativa++;
                Console.Write("Digite sua tentativa: ");

                // Verifica se a entrada do usuário é um número
                if (int.TryParse(Console.ReadLine(), out numeroTentativa))
                {
                    if (numeroTentativa < 1 || numeroTentativa > 100)
                    {
                        Console.WriteLine("Por favor, insira um número entre 1 e 100.");
                        continue;
                    }

                    // Verifica se a tentativa está correta, ou fornece uma dica
                    if (numeroTentativa == numeroSecreto)
                    {
                        Console.WriteLine($"\nParabéns! Você acertou o número em {tentativa} tentativas!");
                        acertou = true;
                    }
                    else if (numeroTentativa < numeroSecreto)
                    {
                        Console.WriteLine("O número é maior. Tente novamente.\n");
                    }
                    else
                    {
                        Console.WriteLine("O número é menor. Tente novamente.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, insira um número.");
                }
            }
        }

        // Questão 77: Verifica se dois arrays possuem os mesmos elementos
        static void Questao77()
        {
            // Declaração dos dois arrays de strings
            string[] array1 = { "maçã", "banana", "laranja", "5" };
            string[] array2 = { "laranja", "maçã", "banana" };

            // Verifica se os arrays têm o mesmo tamanho e se não há elementos diferentes entre eles
            bool iguais = array1.Length == array2.Length && !array1.Except(array2).Any();
            Console.WriteLine(iguais ? "Possui os mesmos elementos." : "Não possui os mesmos elementos."); // Exibe o resultado da verificação
        }

        // Questão 78: Gerencia uma fila de atendimento
        static void Questao78()
        {
            var fila = new FilaAtendimento<string>(); // Cria uma nova fila de atendimento
            Console.WriteLine("Digite os nomes dos clientes (digite 'parar' para encerrar):");

            // Loop para adicionar clientes à fila até que o usuário digite "parar"
            while (true)
            {
                Console.Write("Cliente: ");
                string cliente = Console.ReadLine();

                if (cliente.ToLower() == "parar") // Condição de parada
                {
                    break;
                }
                fila.Enfileirar(cliente); // Adiciona o cliente à fila
            }

            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho()}"); // Exibe o tamanho da fila

            // Loop para atender os clientes na fila até que esteja vazia
            while (!fila.EstaVazia())
            {
                Console.WriteLine($"Atendendo: {fila.Desenfileirar()}"); // Atende o próximo cliente
            }

            Console.WriteLine("Todos os clientes foram atendidos."); // Mensagem final
        }

        // Questão 79: Função do jogo Pedra, Papel e Tesoura
        static void Questao79()
        {
            Console.WriteLine("\n--- Jogo Pedra, Papel e Tesoura ---");
            Console.WriteLine("Escolha: Pedra, Papel ou Tesoura");

            // Opções disponíveis para o jogo
            string[] opcoes = { "PEDRA", "PAPEL", "TESOURA" };
            Random random = new Random(); // Inicializa um gerador de números aleatórios
            string escolhaComputador = opcoes[random.Next(opcoes.Length)]; // Computador faz uma escolha aleatória

            // Jogador faz sua escolha
            Console.Write("Sua escolha: ");
            string escolhaJogador = Console.ReadLine().ToUpper();

            Console.WriteLine($"Computador escolheu: {escolhaComputador}"); // Mostra a escolha do computador

            // Verifica quem ganhou
            if (escolhaJogador == escolhaComputador)
            {
                Console.WriteLine("Empate!"); // Se ambos escolherem a mesma coisa
            }
            else if ((escolhaJogador == "PEDRA" && escolhaComputador == "TESOURA") ||
                     (escolhaJogador == "PAPEL" && escolhaComputador == "PEDRA") ||
                     (escolhaJogador == "TESOURA" && escolhaComputador == "PAPEL"))
            {
                Console.WriteLine("Você ganhou!"); // Jogador ganha
            }
            else
            {
                Console.WriteLine("Computador ganhou!"); // Computador ganha
            }
        }

        // Questão 80: Calcula a soma dos dígitos de um número fornecido pelo usuário
        static void Questao80()
        {
            Console.Write("Digite um número (de preferência maior ou igual a 2 dígitos): ");
            string numero = Console.ReadLine(); // Lê o número fornecido pelo usuário
            int soma = 0; // Inicializa a variável para armazenar a soma dos dígitos

            // Loop através de cada caractere no número
            foreach (char c in numero)
            {
                if (char.IsDigit(c)) // Verifica se o caractere é um dígito
                {
                    soma += int.Parse(c.ToString()); // Adiciona o dígito à soma
                }
            }

            Console.WriteLine($"A soma dos dígitos do número {numero} é: {soma}"); // Exibe a soma
        }

        // Questão 81: Adiciona números a uma lista e exibe os números pares
        static void Questao81()
        {
            List<int> numeros = new List<int>(); // Cria uma nova lista para armazenar números
            Console.WriteLine("Digite a quantidade de números que você deseja adicionar à lista:");
            int quantidade = int.Parse(Console.ReadLine()); // Lê a quantidade de números que o usuário deseja adicionar

            // Loop para adicionar os números à lista
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine()); // Lê o número fornecido pelo usuário
                numeros.Add(numero); // Adiciona o número à lista
            }

            ExibirNumerosPares(numeros); // Chama a função para exibir os números pares
        }

        // Função para exibir números pares
        static void ExibirNumerosPares(List<int> numeros)
        {
            Console.WriteLine("\nNúmeros pares na lista:"); // Mensagem de cabeçalho
            foreach (int numero in numeros) // Loop através dos números na lista
            {
                if (numero % 2 == 0) // Verifica se o número é par
                {
                    Console.WriteLine(numero); // Exibe o número par
                }
            }
        }

        // Questão 82: Calcula a média e o maior valor de uma lista de números fornecidos
        static void Questao82()
        {
            List<double> valores = new List<double>(); // Cria uma nova lista para armazenar os valores
            string input;

            Console.WriteLine("Digite valores numéricos (digite 'sair' para encerrar):");
            while (true) // Loop para ler valores até que o usuário digite "sair"
            {
                Console.Write("Digite um valor: ");
                input = Console.ReadLine(); // Lê o valor fornecido pelo usuário

                if (input.ToLower() == "sair") // Verifica se o usuário deseja encerrar
                {
                    break;
                }

                // Verifica se a entrada pode ser convertida para um número
                if (double.TryParse(input, out double valor))
                {
                    valores.Add(valor); // Adiciona o valor à lista
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número."); // Mensagem de erro
                }
            }

            // Se a lista não estiver vazia, calcula a média e o maior valor
            if (valores.Count > 0)
            {
                double soma = 0; // Inicializa a soma
                foreach (var valor in valores) // Loop para somar os valores
                {
                    soma += valor;
                }
                double media = soma / valores.Count; // Calcula a média
                double maiorValor = double.MinValue; // Inicializa o maior valor

                // Loop para encontrar o maior valor na lista
                foreach (var valor in valores)
                {
                    if (valor > maiorValor)
                    {
                        maiorValor = valor; // Atualiza o maior valor
                    }
                }

                // Exibe a média e o maior valor
                Console.WriteLine($"\nMédia dos valores: {media:F2}");
                Console.WriteLine($"Maior valor informado: {maiorValor}");
            }
            else
            {
                Console.WriteLine("Nenhum valor foi informado."); // Mensagem se a lista estiver vazia
            }
        }

        // Questão 83: Recebe uma lista de nomes e exibe-os em ordem alfabética.
        static void Questao83()
        {
            string[] nomes = new string[10]; // Cria um array para armazenar 10 nomes
            Console.WriteLine("Digite 10 nomes:");

            // Loop para ler 10 nomes do usuário
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine(); // Lê cada nome
            }

            Array.Sort(nomes); // Ordena os nomes em ordem alfabética
            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (var nome in nomes) // Exibe os nomes ordenados
            {
                Console.WriteLine(nome);
            }
        }

        // Questão 84: Verifica se uma palavra ou frase é um palíndromo
        static void Questao84()
        {
            Console.Write("Digite uma palavra ou frase para verificar se é um palíndromo: ");
            string entrada = Console.ReadLine(); // Lê a entrada do usuário

            bool resultado = EhPalindromo(entrada); // Chama a função para verificar palíndromo
            Console.WriteLine(resultado ? "É um palíndromo." : "Não é um palíndromo."); // Exibe o resultado
        }

        // Função auxiliar para verificar se um texto é palíndromo
        static bool EhPalindromo(string texto)
        {
            // Remove espaços e converte para minúsculas
            string textoFormatado = texto.Replace(" ", "").ToLower();

            int inicio = 0; // Posição inicial
            int fim = textoFormatado.Length - 1; // Posição final

            // Verifica os caracteres da extremidade para o centro
            while (inicio < fim)
            {
                if (textoFormatado[inicio] != textoFormatado[fim])
                {
                    return false; // Retorna falso se não for igual
                }
                inicio++;
                fim--;
            }

            return true; // Retorna verdadeiro se for palíndromo
        }

        // Questão 85: Gera números aleatórios e encontra o menor e maior
        static void Questao85()
        {
            Random random = new Random(); // Inicializa o gerador de números aleatórios
            int[] numeros = new int[10]; // Cria um array para armazenar 10 números

            // Gera os números aleatórios entre 1 e 50
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 51); // Gera um número aleatório
            }

            // Exibe os números gerados
            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));

            // Encontra o menor e o maior número
            int menor = numeros.Min(); // Encontra o menor número
            int maior = numeros.Max(); // Encontra o maior número

            // Exibe o menor e o maior número
            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
        }

        // Questão 86: Gerencia uma conta bancária
        static void Questao86()
        {
            // Solicita saldo inicial ao usuário
            Console.Write("Digite o saldo inicial da conta: ");
            decimal saldoInicial = decimal.Parse(Console.ReadLine()); // Lê o saldo inicial

            // Cria a conta bancária com o saldo inicial fornecido
            ContaBancaria conta = new ContaBancaria(saldoInicial);

            // Menu para operações de depósito e saque
            while (true)
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine(); // Lê a opção do usuário

                // Condições para as operações de depósito e saque
                if (opcao == "1")
                {
                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito); // Realiza o depósito
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o valor do saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque); // Realiza o saque
                }
                else if (opcao == "0")
                {
                    break; // Sai do loop
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente."); // Mensagem de erro
                }
            }
        }

        // Questão 87: Calcula e exibe o salário líquido após desconto
        static void Questao87()
        {
            // Solicita o salário bruto do funcionário ao usuário
            Console.Write("Digite o salário bruto do funcionário: R$ ");
            decimal salarioBruto = decimal.Parse(Console.ReadLine()); // Lê o salário bruto

            // Calcula o desconto de 10%
            decimal desconto = salarioBruto * 0.10m;

            // Calcula o salário líquido
            decimal salarioLiquido = salarioBruto - desconto;

            // Exibe o resultado
            Console.WriteLine($"\nSalário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto (10%): R$ {desconto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }

        //Questão 88: Decimal para Binario
        static void Questao88()
        {
            // Solicita ao usuário o número decimal
            Console.Write("Digite um número decimal para converter para binário: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            // Converte o número para binário e exibe o resultado
            string binario = DecimalParaBinario(numeroDecimal);
            Console.WriteLine($"O número {numeroDecimal} em binário é: {binario}");
        }

        static string DecimalParaBinario(int numeroDecimal)
        {
            string binario = "";
            if (numeroDecimal == 0) return "0";

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 2;
                binario = resto + binario;
                numeroDecimal /= 2;
            }

            return binario;
        }

        // Questão 89: Calcula a média das notas de um aluno e verifica se foi aprovado.
        static void Questao89()
        {
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine()); // Lê a primeira nota

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine()); // Lê a segunda nota

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine()); // Lê a terceira nota

            // Calcula a média
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"\nMédia do aluno: {media:F2}"); // Exibe a média formatada

            // Verifica se o aluno foi aprovado
            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }

        // Questão 90: Recebe uma matriz 2x2 e calcula a soma de seus elementos.
        static void Questao90()
        {
            int[,] matriz = new int[2, 2]; // Cria uma matriz 2x2
            Console.WriteLine("Digite os elementos da matriz 2x2:");

            // Loop para preencher a matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine()); // Lê cada elemento da matriz
                }
            }

            int soma = SomarElementosMatriz(matriz); // Chama função para somar os elementos
            Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}"); // Exibe a soma
        }

        // Função para somar os elementos de uma matriz 2x2
        static int SomarElementosMatriz(int[,] matriz)
        {
            int soma = 0; // Inicializa a soma
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    soma += matriz[i, j]; // Soma os elementos
                }
            }
            return soma; // Retorna a soma
        }

        // Questão 91: Sistema de votação para três candidatos
        static void Questao91()
        {
            // Inicializa contadores de votos para os três candidatos
            int votosCandidato1 = 0;
            int votosCandidato2 = 0;
            int votosCandidato3 = 0;

            // Solicita o número de eleitores
            Console.Write("Digite o número de eleitores: ");
            int numeroEleitores = int.Parse(Console.ReadLine()); // Lê o número de eleitores

            // Instruções para votação
            Console.WriteLine("\nVotação: Escolha 1, 2 ou 3 para os candidatos.");
            Console.WriteLine("1 - Candidato 1");
            Console.WriteLine("2 - Candidato 2");
            Console.WriteLine("3 - Candidato 3");

            // Loop para registrar os votos
            for (int i = 1; i <= numeroEleitores; i++)
            {
                Console.Write($"\nVoto do eleitor {i}: ");
                int voto = int.Parse(Console.ReadLine()); // Lê o voto

                // Conta o voto para o candidato escolhido
                switch (voto)
                {
                    case 1:
                        votosCandidato1++; // Incrementa votos do candidato 1
                        break;
                    case 2:
                        votosCandidato2++; // Incrementa votos do candidato 2
                        break;
                    case 3:
                        votosCandidato3++; // Incrementa votos do candidato 3
                        break;
                    default:
                        Console.WriteLine("Voto inválido! Escolha 1, 2 ou 3.");
                        i--; // Repete o voto para o eleitor atual
                        break;
                }
            }

            // Exibe os resultados
            Console.WriteLine("\nResultado da votação:");
            Console.WriteLine($"Candidato 1: {votosCandidato1} votos");
            Console.WriteLine($"Candidato 2: {votosCandidato2} votos");
            Console.WriteLine($"Candidato 3: {votosCandidato3} votos");

            // Verifica o vencedor
            if (votosCandidato1 > votosCandidato2 && votosCandidato1 > votosCandidato3)
            {
                Console.WriteLine("O vencedor é o Candidato 1!");
            }
            else if (votosCandidato2 > votosCandidato1 && votosCandidato2 > votosCandidato3)
            {
                Console.WriteLine("O vencedor é o Candidato 2!");
            }
            else if (votosCandidato3 > votosCandidato1 && votosCandidato3 > votosCandidato2)
            {
                Console.WriteLine("O vencedor é o Candidato 3!");
            }
            else
            {
                Console.WriteLine("A votação terminou empatada!");
            }
        }

        // Questão 92: Verifica se um número é múltiplo de 3 e 7 simultaneamente
        static void Questao92()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()); // Lê um número do usuário

            // Verifica se o número é múltiplo de 3 e 7 ao mesmo tempo
            if (numero % 3 == 0 && numero % 7 == 0)
            {
                Console.WriteLine($"O número {numero} é múltiplo de 3 e 7 ao mesmo tempo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é múltiplo de 3 e 7 ao mesmo tempo.");
            }
        }

        // Questão 93: Função para calcular a distância entre dois pontos
        static void Questao93()
        {
            Console.WriteLine("\n--- Cálculo de Distância entre Dois Pontos ---");

            // Entrada dos pontos
            Console.Write("Digite o valor de x1: ");
            double x1 = double.Parse(Console.ReadLine()); // Lê x1

            Console.Write("Digite o valor de y1: ");
            double y1 = double.Parse(Console.ReadLine()); // Lê y1

            Console.Write("Digite o valor de x2: ");
            double x2 = double.Parse(Console.ReadLine()); // Lê x2

            Console.Write("Digite o valor de y2: ");
            double y2 = double.Parse(Console.ReadLine()); // Lê y2

            // Cálculo da distância usando a fórmula da distância euclidiana
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"A distância entre os pontos é: {distancia:F2}"); // Exibe a distância formatada
        }

        // Questão 94: Ordena uma lista de números 
        static void Questao94()
        {
            List<int> numerosAleatorios = GerarNumerosAleatorios(5); // Gera 5 números aleatórios
            numerosAleatorios.Sort(); // Ordena a lista em ordem crescente
            Console.WriteLine("Números aleatórios em ordem crescente: " + string.Join(", ", numerosAleatorios)); // Exibe a lista ordenada
        }

        // Função para gerar uma lista de números aleatórios
        static List<int> GerarNumerosAleatorios(int quantidade)
        {
            Random random = new Random(); // Inicializa o gerador de números aleatórios
            List<int> numeros = new List<int>(); // Cria uma lista para armazenar os números

            // Gera números aleatórios entre 1 e 100
            for (int i = 0; i < quantidade; i++)
            {
                int numero = random.Next(1, 101);
                numeros.Add(numero); // Adiciona o número gerado à lista
            }

            return numeros; // Retorna a lista de números
        }

        // Questão 95: Agenda de contatos com opções de adicionar e listar
        static void Questao95()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda de Contatos:");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarContato(); // Chama a função para adicionar um novo contato
                        break;
                    case 2:
                        ListarContatos(); // Chama a função para listar os contatos existentes
                        break;
                }
            } while (opcao != 0); // Continua no loop até que o usuário escolha voltar
        }

        static void AdicionarContato()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine(); // Captura o nome do contato
            Console.Write("Digite o número de telefone: ");
            string telefone = Console.ReadLine(); // Captura o telefone do contato
            agenda.Add(new Contato { Nome = nome, Telefone = telefone }); // Adiciona o contato à lista
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        static void ListarContatos()
        {
            Console.WriteLine("Contatos:");
            foreach (var contato in agenda) // Itera sobre a lista de contatos
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}"); // Exibe os detalhes de cada contato
            }
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey(); // Aguarda o usuário pressionar 'enter'
        }

        // Questão 96: Exibe todos os números primos entre 1 e 100
        static void Questao96()
        {
            Console.WriteLine("Números primos entre 1 e 100:");
            for (int i = 2; i <= 100; i++)
            {
                if (EhPrimo(i)) // Verifica se o número é primo
                {
                    Console.Write($"{i} "); // Exibe o número primo
                }
            }
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey(); // Aguarda o usuário pressionar 'enter'
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false; // Números menores ou iguais a 1 não são primos
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false; // Se o número for divisível por qualquer número até sua raiz quadrada, não é primo
            }
            return true; // O número é primo
        }

        // Questão 97: Exibe a tabuada de um número fornecido pelo usuário
        static void Questao97()
        {
            Console.Write("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine()); // Captura o número para a tabuada

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}"); // Exibe a tabuada
            }
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey(); // Aguarda o usuário pressionar 'enter'
        }

        // Questão 98: Encontra o maior número em uma matriz 3x3
        static void Questao98()
        {
            int[,] matriz = {
        { 1, 5, 3 },
        { 4, 9, 2 },
        { 7, 6, 8 }
    };

            int maior = MaiorNumero(matriz); // Chama a função para encontrar o maior número na matriz
            Console.WriteLine($"O maior número na matriz é: {maior}"); // Exibe o maior número encontrado
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey(); // Aguarda o usuário pressionar 'enter'
        }

        static int MaiorNumero(int[,] matriz)
        {
            int maior = matriz[0, 0]; // Inicializa o maior número com o primeiro elemento da matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] > maior) // Verifica se o elemento atual é maior que o maior encontrado
                    {
                        maior = matriz[i, j]; // Atualiza o maior número
                    }
                }
            }
            return maior; // Retorna o maior número encontrado
        }

        // Questão 99: Calcula a soma dos quadrados de 1 até um número N 
        static void Questao99()
        {
            Console.Write("Digite um número N: ");
            int N = int.Parse(Console.ReadLine()); // Captura o número N
            int soma = SomaDosQuadrados(N); // Chama a função para calcular a soma dos quadrados
            Console.WriteLine($"A soma dos quadrados dos números de 1 a {N} é: {soma}"); // Exibe a soma calculada
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey(); // Aguarda o usuário pressionar 'enter'
        }

        static int SomaDosQuadrados(int N)
        {
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i * i; // Adiciona o quadrado do número atual à soma
            }
            return soma; // Retorna a soma total
        }

        //Questão 100: Jogo da Forca
        static void Questao100()
        {
            // Palavra secreta
            string palavra = "CANDELABRO";

            // Tamanho da palavra
            int tamanho = palavra.Length;

            // Vetor para armazenar as letras já descobertas
            char[] descobertas = new char[tamanho];

            // Inicializar vetor com underscores
            for (int i = 0; i < tamanho; i++)
            {
                descobertas[i] = '_';
            }

            // Número de tentativas
            int tentativas = 5;

            Console.WriteLine("Jogo de Forca!");

            // Loop de jogo
            while (tentativas > 0)
            {
                Console.WriteLine("\nPalavra: " + string.Join(" ", descobertas));
                Console.WriteLine($"Tentativas restantes: {tentativas}");

                // Pedir letra ao usuário
                Console.Write("Digite uma letra: ");
                string letra = Console.ReadLine().ToUpper();

                // Verificar se a letra está na palavra
                bool acertou = false;
                for (int i = 0; i < tamanho; i++)
                {
                    if (palavra[i] == letra[0])
                    {
                        descobertas[i] = letra[0];
                        acertou = true;
                    }
                }

                // Verificar se o usuário ganhou
                if (string.Join("", descobertas) == palavra)
                {
                    Console.WriteLine("\nParabéns! Você ganhou!");
                    return;
                }

                // Penalizar se não acertou
                if (!acertou)
                {
                    tentativas--;
                    Console.WriteLine("Letra não encontrada!");
                }
            }

            // Fim do jogo
            Console.WriteLine("\nGame Over! A palavra era: " + palavra);
        }


    }
}






