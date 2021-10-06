using System;

namespace Bank.Dio1
{
    class Program
    {

        static List<Conta> ListContas = new List<Conta>();
        static void Main(string[] args)
        {
            string OpcaoUsuario - ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "x")
            {
                 switch (opcaoUsuario)
                 {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        inserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break

                     default:
                        throw new ArgumentOutOfRangeException();
                 }

                 opcaoUsuario = ObterOpcaoUsuario
            }

            Console.WriteLine("Obrigado pro confiar em nós :)")
            Console.ReadLine();

        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de Origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de Destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("DIgite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }
        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque - double.Parse(Console.ReadLine());

            listContas(indiceConta).Sacar(valorSaque);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito - double.Parse(Console.ReadLine());

            listContas(indiceConta).Depositar(valorDeposito);
        }
        private static void inserirConta()
        {
            Console.WriteLine("Inserir nova Conta");

            Console.Write("Digite '1' para conta Fisica ou '2' para Juridica: ")
            int entradaTipoConta - int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Perse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            ListContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {  
               Console.WriteLine("Nenhuma conta cadastrada!");
               return 
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas(i);
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static static ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("MINHOBANK BEM-VINDO");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Listar Contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferencia");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Encerrar");
            Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }
    }
}
