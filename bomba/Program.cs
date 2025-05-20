using Classes;
using Layout;

Torneira.Vazao = 4;
Bomba.Vazao = 3;
Caixa.NivelAtual = 100;
Reservatorio.NivelAtual = 100;
Caixa.Saida = 2;

string txt = "Sistema de Controle de Nível de Água";

while (true)
{
    Thread.Sleep(1000);
    Console.Clear();
    bool ? bombaEstado = Bomba.Estado(Caixa.SensorA, Caixa.SensorB);
    bool ? torneiraEstado = Torneira.Estado(Reservatorio.SensorA, Reservatorio.SensorB);
    Formatação.Cor(ConsoleColor.Yellow);
    Formatação.ImprimirCabecalho(txt);
    Formatação.Cor(ConsoleColor.White);

    if (bombaEstado == true)
    {
        Console.Write($"Caixa: {Caixa.NivelAtual} % ");
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("↑");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Console.Write($"Caixa: {Caixa.NivelAtual} % ");
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("↓");
        Formatação.Cor(ConsoleColor.White);
    }

    if (torneiraEstado == true)
    {
        Console.Write($"Reservatorio: {Reservatorio.NivelAtual} % ");
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("↑");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Console.Write($"Reservatorio: {Reservatorio.NivelAtual} % ");
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("↓");
        Formatação.Cor(ConsoleColor.White);
    }

    Console.WriteLine();

    Caixa.NivelAtual -= Caixa.Saida;

    if (bombaEstado == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Bomba Ligada");
        Formatação.Cor(ConsoleColor.White);
        Reservatorio.NivelAtual -= Bomba.Vazao;
        Caixa.NivelAtual += Reservatorio.Saida;
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Bomba Desligada");
        Formatação.Cor(ConsoleColor.White);
    }

    if (torneiraEstado == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Torneira Ligada");
        Formatação.Cor(ConsoleColor.White);
        Reservatorio.NivelAtual += Torneira.Vazao;
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Torneira Desligada");
        Formatação.Cor(ConsoleColor.White);
    }

    Console.WriteLine();

    if (Reservatorio.SensorA == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Sensor superior do reservatorio ligado");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Sensor superior do reservatorio desligado");
        Formatação.Cor(ConsoleColor.White);
    }

    if (Reservatorio.SensorB == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Sensor inferior do reservatorio ligado");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Sensor inferior do reservatorio desligado");
        Formatação.Cor(ConsoleColor.White);
    }

    if (Caixa.SensorA == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Sensor superior da caixa ligado");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Sensor superior da caixa desligado");
        Formatação.Cor(ConsoleColor.White);
    }

    if (Caixa.SensorB == true)
    {
        Formatação.Cor(ConsoleColor.Green);
        Console.WriteLine("Sensor inferior da caixa ligado");
        Formatação.Cor(ConsoleColor.White);
    }
    else
    {
        Formatação.Cor(ConsoleColor.Red);
        Console.WriteLine("Sensor inferior da caixa desligado");
        Formatação.Cor(ConsoleColor.White);
    }
}



