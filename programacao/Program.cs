try
{
    int idade;
    float orcamento, valorPLano = 0;
    Boolean temDesconto = false;
    string nomePLano = "";

    Console.WriteLine(" Digite sua idade: \n");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine(" Digite seu orçamento: \n");
        orcamento = float.Parse(Console.ReadLine());
        if (orcamento <= 100)
        {
            if (orcamento >= 40)
            {
                temDesconto = !temDesconto;
            }
            else
            {
                Console.WriteLine("Você não tem saldo o suficiente.");
                return;
            }
        }

        int plano = 0;

        Planos planoEscolhido = 0;
        if (idade <= 30)
        {
            Console.WriteLine(" Suas opções de planos São.\n Plano Padrão 50,00. Digite (0).\n Plano Premium 80,00. Digite (1)");
            plano = int.Parse(Console.ReadLine());
            planoEscolhido = (Planos)plano;
            if (Planos.Padrao == planoEscolhido)
            {
                valorPLano = 50.00F;
                nomePLano = "Padrão";
            }
            else
            {
                valorPLano = 80.00F;
                nomePLano = "Premium";
            }
        }
        else
        {
            Console.WriteLine(" Suas opções de planos São.\n Plano Padrão 70,00. Digite (2).\n Plano Premium 100,00. Digite (3)");
            plano = int.Parse(Console.ReadLine());
            planoEscolhido = (Planos)plano;

            if (Planos.PadraoPlus == planoEscolhido)
            {
                valorPLano = 70.00F;
                nomePLano = "Padrão";
            }
            else
            {
                valorPLano = 100.00F;
                nomePLano = "Premium";
            }

        }

    }
    else
    {
        Console.WriteLine(" Você é menor de idade. Não pode escolher um plano.");
        return;
    }

    if (temDesconto)
    {
        valorPLano = valorPLano - (valorPLano * 0.2F);
        Console.WriteLine(" Seu Plano é o " + nomePLano + ", o valor é de " + valorPLano.ToString("C"));
    }
    else
    {
        Console.WriteLine(" Seu Plano é o " + nomePLano + ", o valor é de " + valorPLano.ToString("C"));
    }
}
catch
{

}