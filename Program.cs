// Projeto Screen Sound
string mensagemBoasVindas = "Seja bem vindo!!";
List<string>listaBandas = new List<string>();


void ExibirLogo()
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
    ExibirLogo();
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
        case 1:RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3:MostrarBandasRegistradas();
            break;
        case 4: Console.WriteLine("Você escolheu a opção: "+opcaoEscolhidaNumero);
            break;   
        case -1: Console.WriteLine("Você escolheu a opção: "+opcaoEscolhidaNumero);
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda(){
    Console.Clear();
    ExibirTitulo("REGISTRAR BANDA");
    Console.Write("DIGITE O NOME DA BANDA: ");
    String nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTitulo("Exibindo as bandas registradas:");
    /*for(int i = 0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }*/
    foreach (String banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}
void ExibirTitulo(string Titulo)
{
    int qtdLetras = Titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*' );
    Console.WriteLine(asteriscos);
    Console.WriteLine(Titulo);
    Console.WriteLine(asteriscos + "\n");
}
//ExibirLogo();
ExibirMenu();
