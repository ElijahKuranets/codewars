namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
   double result;

            if (operation == '+')
                return result = value1 + value2;
            else if (operation == '-')
                return result = value1 - value2;
            else if (operation == '*')
                return result = value1 * value2;
            else if (operation == '/')
                return result = value1 / value2;
            else
                return 0;
    }
  }
}