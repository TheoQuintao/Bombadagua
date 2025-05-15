int caixa = 50,
    reservatorio = 50;

bool bomba = false,
    torneira = false,
    sa = false,
    sb = false,
    sc = false,
    erro = false;
    

while(true)
{
    caixa-=2;
    Console.WriteLine($"Caixa d'água: {caixa}%");
    Console.WriteLine($"Reservatorio: {reservatorio}%\n\n");
    if(reservatorio<30)
    {
        sa = false;
        sb = false;
    }
    else if(reservatorio>30 && reservatorio<80)
    {
        sa = true;
        sb = false;
    }
    else if(reservatorio>80)
    {
        sa = true;
        sb = true;
    }

    if(caixa<80)
    {
        sc = false;
    }
    else if(caixa>80)
    {
        sc = true;
    }

    if(sa == false && sb == false)
    {
        torneira = true;
    }
    else if(sa == true && sb == true)
    {
        torneira = false;
    }



    if(erro == true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O sistema deu ERRO!!!!");
        break;
    }

    if(sa == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sensor A: ligado");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sensor A: Desligado");
        Console.ResetColor();
    }

    if(sb == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sensor b: ligado");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sensor b: Desligado");
        Console.ResetColor();
    }

    if(sc == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sensor c: ligado");
        Console.ResetColor();
        bomba = false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sensor c: Desligado");
        Console.ResetColor();
        bomba = true;
    }

    
    Console.WriteLine();
    if(torneira == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        reservatorio+=4;
        Console.WriteLine("Torneira: ligada");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Torneira: desligada");
        Console.ResetColor();
    }

    if(bomba == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        reservatorio-=3;
        caixa+=3;
        Console.WriteLine("Bomba: ligada");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Bomba: desligada");
        Console.ResetColor();
    }

    Console.WriteLine("\nCurso: Tecnico de Informatica para a internet\nAluno: Théo Oliveira Quintão");
    Thread.Sleep(750);
    Console.Clear();
}