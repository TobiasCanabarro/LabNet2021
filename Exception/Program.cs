using System;

public class Program
{

    public readonly string _ok_state = "Se pudo hacer la operacion!";
    public readonly string _fail_state = "No se pudo hacer la operacion!";

    public Program()
	{
        string state = _ok_state;
        float result = 0;
        int divider = 0;
        int num = 10;

		try
        {
            result = num / divider;
        }
        catch(DivideByZeroException ex)
        {
            value = _fail_state;
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            Console.WriteLine($"{value}, el resultado es {result}");
        }
        Console.ReadKey();
	}
}
