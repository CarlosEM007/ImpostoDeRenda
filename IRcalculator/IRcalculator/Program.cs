using IRcalculator.Controllers;
using IRcalculator.View;

class Program
{
    static void Main(string[] args)
    {
        int op;
        do
        {
            Menu.Use();
            op = int.Parse(Console.ReadLine());

            Operations.Options(op);

            Console.WriteLine("\nPrecione qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();

        } while (op != 7);

    }
}