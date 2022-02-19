namespace Calcool6.Application;

public static class AdvancedCalculation
{
    public static double Power(double input1, double input2)
    {
        return Math.Pow(input1, input2);
    }

    public static int Remainder(int input1, int input2)
    {
        if (input2 == 0)
        {
            throw new DivideByZeroException("Tidak boleh dibagi dengan nol.");
        }

        return input1 % input2;
    }
}
