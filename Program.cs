// Projeto Screen Sound
using System.Collections;
using System.Collections.Specialized;
using System.Xml;

string mensagemBoasVindas = "Seja bem vindo!!";
//List<string>listaBandas = new List<string>();
Dictionary<string, List<int>>bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Avioes", new List<int>{10,8});//inserindo a banda e notas
bandasRegistradas.Add("Limao com Mel", new List<int>());//Inserindo banda sem notas

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
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMedia();
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
    //listaBandas.Add(nomeBanda);
    //usando agora o dicionário
    bandasRegistradas.Add(nomeBanda,new List<int>());
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
    //o foreach está sendo pelas chaves do dicionário, ou seja, as bandas.
    foreach (String banda in bandasRegistradas.Keys)
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
void AvaliarBanda()
{
    //digitar a banda que deseja avaliar
    //se a bamda existir >> atribuir uma nota>>senão volta ao menu principal
    Console.Clear();
    ExibirTitulo("Avaliar Banda:");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    //buscar se existe esta chave(banda) no dicionário.
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite a nota da banda: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota: {notaBanda} foi resgistrada com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();

    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Média da Banda:");
    Console.Write("Digite o nome da banda que deseja exibor a média. ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notaDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é: {notaDaBanda.Average()}");//calcula a média da banda
        Console.WriteLine("Digite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}

//ExibirLogo();
ExibirMenu();
