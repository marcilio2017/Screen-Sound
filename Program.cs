// Projeto Screen Sound
string mensagemBoasVindas = "Seja bem vindo!!";


void ExibirMEnsagem()
{
    Console.WriteLine(@"
    
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas); 
}

void ExibirMenu()
{
    Console.WriteLine(" \n1 - REGISTRAR BANDA");
    Console.WriteLine(" 2 - LISTAR BANDA");
    Console.WriteLine(" 3 - AVALIAR BANDA");
    Console.WriteLine(" 4 - EXIBIR MEDIA DA BANDA");
    Console.WriteLine("-1 - SAIR");

    Console.Write("\nDigite sua opção:");
    String opcaoEscolhida = Console.ReadLine()!;//esclamação some a marcação do readline.
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);//usando conversões para comparar no IF.
    switch (opcaoEscolhidaNumero)
    {
        case 1: Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumero);
            break;
        case 2: Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumero);
            break;
        case 3: Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumero);
            break;
        case 4: Console.WriteLine("Você escolheu a opção: "+opcaoEscolhidaNumero);
            break;   
        case -1: Console.WriteLine("Você escolheu a opção: "+opcaoEscolhidaNumero);
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

ExibirMEnsagem();
ExibirMenu();
