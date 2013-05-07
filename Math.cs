using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorNew;

public partial class Math : Form1
{
    internal static double? Addition(double? F1, double? F2, double? result)
    {
        result = F1 + F2;
        return result;
    }

    internal static double? Subtraction(double? F1, double? F2, double? result)
    {
        result = F1 - F2;
        return result;
    }

    internal static double? Multiplication(double? F1, double? F2, double? result)
    {
        result = F1 * F2;
        return result;
    }

    internal static double? Division(double? F1, double? F2, double? result)
    {
        result = F1 / F2;
        return result;
    }
}
