using System;

class Program
{
    public static void Main()
    {
        double first = 0;
        string op = "0";
        double second = 0;
        
        Console.WriteLine("Input q or -1 to quit");

        while (true)
        {
            first = InputNumber();
            if (first == -1) break;

            op = InputOperate();
            if (op == "q") break;

            if (op != "sqrt") 
            {
                second = InputNumber();
                if (second == -1) break;
            }

            CalculateAndPrint(first, op, second);
        }
    }

    static double InputNumber()
    {
        string input = "";
        while (input == "") {
            Console.Write("Input the number: ");
            input = Console.ReadLine();
        };

        if (input == "q") return -1d;
        double num = Double.Parse(input);
        return num;
    }

    static string InputOperate()
    {
        string input = "";
        while ( input != "+" && 
                input != "-" && 
                input != "*" && 
                input != "/" && 
                input != "**" && 
                input != "sqrt" && 
                input != "%" ) {
            Console.Write("Input operator (+, -, *, /, **, sqrt or %): ");
            input = Console.ReadLine();
        };

        if (input == "-1") return "q";
        return input;
    }

    static void CalculateAndPrint(double f, string op, double s)
    {
        double result = 0;

        switch(op)
        {
            case "+":
                result = f + s; break;
            case "-":
                result = f - s; break;
            case "*":
                result = f * s; break;
            case "/":
                result = f / s; break;
            case "**":
                result = Math.Pow(f, s); break;
            case "sqrt":
                result = Math.Sqrt(f); break;
            case "%":
                result = f % s; break;
        }

        switch(op)
        {
            case "+":
            case "-":
            case "*":
            case "/":
            case "**":
            case "%":
                Console.WriteLine($"\n{f} {op} {s} = {result}\n"); break;
            case "sqrt":
                Console.WriteLine($"\n{op}({f}) = {result}\n"); break;
        }
    }
}