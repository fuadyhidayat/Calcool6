namespace Calcool6.Application;

public static class SimpleCalculation
{
    public static int Add(int input1, int input2)
    {
        return input1 + input2;
    }

    public static int Subtract(int input1, int input2)
    {
        return input1 - input2;
    }

    public static int Multiply(int input1, int input2)
    {
        return input1 * input2;
    }

    public static double Divide(int input1, int input2)
    {
        return input1 / (double)input2;
    }
}
