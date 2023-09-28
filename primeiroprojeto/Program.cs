// Screen Sound
using System;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);  
};


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digire 2 para mostrar uma banda");
    Console.WriteLine("Digire 3 para avaliar uma banda");
    Console.WriteLine("Digire 4 para exibir a média de uma banda");
    Console.WriteLine("Digire 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    Console.ReadLine();
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)  
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;
        case 2:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;
        case 3:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;
        case 0:
            Console.WriteLine("Tchau Tchau :)");
            break;
        default:
            Console.WriteLine("[ERRO] Opção inválida. Digite novamente sua opção.");
            ExibirOpcoesDoMenu();
            break;

    }
}
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

 



