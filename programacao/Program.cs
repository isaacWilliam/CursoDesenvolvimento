using System.Security.Cryptography.X509Certificates;
public class PlanosAssinatura
{
    public static void Main()
    {
        try
        {
            int idade;
            float orcamento;
            int plano = 0;
            float valorPLano = 0;
            Planos planoEscolhido = 0;
            Boolean temDesconto = false;

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu orçamento: ");
            orcamento = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite 'sim' se possuir desconto");
            string desconto = Console.ReadLine();

            if (desconto == "sim")
            {
                temDesconto = true;
            }

            if (idade >= 18)
            {
                if (idade <= 30)
                {
                    Console.WriteLine("Suas opções de planos São.\n Plano Padrão 50,00. Digite (0).\n Plano Premium 80,00. Digite (1)");
                    plano = int.Parse(Console.ReadLine());
                    planoEscolhido = (Planos)plano;
                    if (Planos.Padrao == planoEscolhido)
                    {
                        valorPLano = 50.00F;
                    }
                    else
                    {
                        valorPLano = 80.00F;
                    }
                }
                else
                {
                    Console.WriteLine("Suas opções de planos São.\n Plano Padrão 70,00. Digite (2).\n Plano Premium 100,00. Digite (3)");
                    plano = int.Parse(Console.ReadLine());
                    planoEscolhido = (Planos)plano;

                    if (Planos.PadraoPlus == planoEscolhido)
                    {
                        valorPLano = 70.00F;
                    }
                    else
                    {
                        valorPLano = 100.00F;
                    }

                }

            }
            else
            {
                Console.WriteLine("Você é menor de idade. Não pode escolher um plano.");
            }

            if (temDesconto)
            {
                valorPLano = valorPLano - ((valorPLano * 20) / 100);
                Console.WriteLine("Seu Plano é o " + planoEscolhido + ", o valor é de " + valorPLano.ToString("C"));
            }
            else
            {
                Console.WriteLine("Seu Plano é o " + planoEscolhido + ", o valor é de " + valorPLano.ToString("C"));
            }
        }
        catch
        {

        }

    }
}