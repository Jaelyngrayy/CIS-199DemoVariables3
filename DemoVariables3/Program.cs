using static System.Console;
class DemoVariables3
{
    static void Main()
    {
        int comparisonValue = 10;
        bool isSixMore = 6 > comparisonValue;
        WriteLine("When compairsonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);
        comparisonValue = 2;
        isSixMore = 6 > comparisonValue;
        WriteLine("When compairsonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);

    }
}