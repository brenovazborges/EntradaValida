int number;

Console.WriteLine("---->ATIVIDADE DE 'ENTRADA VALIDA<----/n");
InsertNumber();

if (number ==0 )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Operação cancelada :(");
    Console.ResetColor();
}

else
{
    if (number <=9 )
    {
        Console.WriteLine("Volte sempre! :)");
    }

    else
    {
        InsertNumber();
    }
}












void InsertNumber()
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...:");
    number = Convert.ToInt32(Console.ReadLine());
}