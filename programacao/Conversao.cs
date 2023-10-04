// public static class Conversao{

//     public static void Main(){
//         Console.WriteLine("Digite um numero");
//     }
// }


    Console.WriteLine("Quanto você tem? \b");
    decimal dinheiroTem = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Escolha para qual moeda deseja: \n 1 - Real Para Dólar \n 2 - Dólar para Real\n 3 - Real Para Euro \n 4 - Euro Para Real \n 5 - Real Para Libra Esterlina \n 6 - Libra Esterlina Para Real\n 7 - Real Para Iene\n 8 - Iene Para Real \n 9 - Real Para Franco Suiço\n 10 - Franco Suiço Para Real");
    int conversao = int.Parse(Console.ReadLine());

    ConversaoMoeda conversaoEscolhida = (ConversaoMoeda)conversao;

    switch(conversaoEscolhida){
        case ConversaoMoeda.RealParaDolar:
            RealEDolar(1, dinheiroTem);
        break;
        case ConversaoMoeda.DolarParaReal:
            RealEDolar(0, dinheiroTem);
        break;
        case ConversaoMoeda.RealParaEuro:
            RealEEuro(1, dinheiroTem);
        break;
        case ConversaoMoeda.EuroParaReal:
            RealEEuro(0, dinheiroTem);
        break;
        case ConversaoMoeda.RealParaLibraEsterlina:
            RealELibraEsterlina(1, dinheiroTem);
        break;
        case ConversaoMoeda.LibraEsterlinaParaReal:
            RealELibraEsterlina(0, dinheiroTem);
        break;
        case ConversaoMoeda.RealParaIeneJapones:
            RealEIene(1, dinheiroTem);
        break;
        case ConversaoMoeda.IeneJaponesParaReal:
            RealEIene(0, dinheiroTem);
        break;
        case ConversaoMoeda.RealParaFrancoSuico:
            RealEFrancoSuico(1, dinheiroTem);
        break;
        case ConversaoMoeda.FrancoSuicoParaReal:
            RealEFrancoSuico(0, dinheiroTem);
        break;
    }

    void RealEDolar(decimal auxiliar, decimal dinheiro){
        if(auxiliar == 1){
            dinheiro = dinheiro / Constantes.DOLAR;
            Console.WriteLine($"Seu dinheiro convertido ficou em: R$ {Math.Round(dinheiro, 2)}");
        }else{
            dinheiro = dinheiro * Constantes.DOLAR;
            Console.WriteLine($"Seu dinheiro convertido ficou em: US$ {Math.Round(dinheiro, 2)}");
        }
        
    }
    void RealEEuro(decimal auxiliar, decimal dinheiro){
        if(auxiliar == 1){
            dinheiro = dinheiro / Constantes.EURO;
            Console.WriteLine($"Seu dinheiro convertido ficou em: R$ {Math.Round(dinheiro, 2)}");
        }else{
            dinheiro = dinheiro * Constantes.EURO;
            Console.WriteLine($"Seu dinheiro convertido ficou em: EU$ {Math.Round(dinheiro, 2)}");
        }
        
    }
    void RealELibraEsterlina(decimal auxiliar, decimal dinheiro){
        if(auxiliar == 1){
            dinheiro = dinheiro / Constantes.LIBRA_ESTERLINA;
            Console.WriteLine($"Seu dinheiro convertido ficou em: R$ {Math.Round(dinheiro, 2)}");
        }else{
            dinheiro = dinheiro * Constantes.LIBRA_ESTERLINA;
            Console.WriteLine($"Seu dinheiro convertido ficou em: LE${Math.Round(dinheiro, 2)}");
        }
    }
    void RealEIene(decimal auxiliar, decimal dinheiro){
        if(auxiliar == 1){
            dinheiro = dinheiro / Constantes.IENE_JAPONES;
            Console.WriteLine($"Seu dinheiro convertido ficou em: R$ {Math.Round(dinheiro, 2)}");
        }else{
            dinheiro = dinheiro * Constantes.IENE_JAPONES;
            Console.WriteLine($"Seu dinheiro convertido ficou em: IE$ {Math.Round(dinheiro, 2)}");
        }
    }
    void RealEFrancoSuico(decimal auxiliar, decimal dinheiro){
        if(auxiliar == 1){
            dinheiro = dinheiro / Constantes.FRANCO_SUICO;
            Console.WriteLine($"Seu dinheiro convertido ficou em: R$ {Math.Round(dinheiro, 2)}");
        }else{
            dinheiro = dinheiro * Constantes.FRANCO_SUICO;
            Console.WriteLine($"Seu dinheiro convertido ficou em: FR${Math.Round(dinheiro, 2)}");
        }
    }
