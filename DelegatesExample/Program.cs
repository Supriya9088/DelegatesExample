using System;
public delegate int Calculation(int numOne, int numTwo);
    class Mathematics
{
    static int Addition(int numOne, int numTwo)
    { 
        return (numOne + numTwo);
    }
    static int Substraction(int numOne, int numTwo)
    {
        return (numOne - numTwo);
    }

    static int Multiplication(int numOne, int numTwo)
    {
        return (numOne * numTwo);
    }

    static int Division(int numOne, int numTwo)
    {
        return (numOne / numTwo);
    }
    static void Main(string[] args)
    {
        int valOne = 5;
        int valTwo = 23;
        Calculation objCalculation = new Calculation(Addition);
        Console.WriteLine(valOne + "+" + valTwo + "=" + objCalculation(valOne,valTwo));
        Calculation objCal=new Calculation(Substraction);
        Console.WriteLine(valOne + "-" + valTwo + "=" + objCal(valOne, valTwo));
        Calculation objCal2 = new Calculation(Multiplication);
        Console.WriteLine(valOne + "*" + valTwo + "=" + objCal2(valOne, valTwo));

        Calculation objCal3 = new Calculation(Division);
        Console.WriteLine(valOne + "/" + valTwo + "=" + objCal3(valOne, valTwo));
    }
}

