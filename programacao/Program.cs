using System.Security.Cryptography.X509Certificates;
public class PlanosAssinatura
{
    public static void Main()
    {
        int idade;
        float orcamento;
        Boolean temDesconto = false;

        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu orçamento: ");
        orcamento = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite se sim se possuir desconto");
        string desconto = Console.ReadLine();

        if (desconto == "sim")
        {
            temDesconto = true;
        }
        if (idade >= 18)
        {
            if(idade <= 30){
                Console.WriteLine("Suas opções de planos São.\n Plano Padrão 50,00. Digite (0).\n Plano Premium 80,00. Digite (1)");
                
            }else{

            }
        }else
        {
            Console.WriteLine("Você é menor de idade. Não pode escolher um plano.");
        }

    }
}