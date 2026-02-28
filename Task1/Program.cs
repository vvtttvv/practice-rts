namespace  Task1;

using System;
using System.Text;

class Program
{
    static void Main(string [ ] args)
    {
        ShowEnvironment.GetInfo();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        int var = default;
        Console.WriteLine(var.GetType());
        DataTypeFunctionality();
        EscapeChars();
        StringComparisonRevised();
        StnngEqualitySpecifyingCompareRules();
        FunWithStnngBuilder();

    }

    static void DataTypeFunctionality()
    {
        Console.WriteLine("=> Data type Functionality:");
        Console.WriteLine("Max of int: {0}", int.MaxValue);
        Console.WriteLine("Min of int: {0}", int.MinValue);
        Console.WriteLine("Max of double: {0}", double.MaxValue);
        Console.WriteLine("Min of double: {0}", double.MinValue);
        Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
        Console.WriteLine("double.Negativelnfinity: {0}", double.NegativeInfinity);
        Console.WriteLine();
        double newVal = 123_321.125_456;
        Console.WriteLine(newVal);
    }

    static void EscapeChars()
    {
        Console.WriteLine("=> Escape characters:");
        string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
        string strWithTabs2 = "fddddddddddddd\tColor\tSpeed\tPet Name ";
        Console.WriteLine(strWithTabs);
        Console.WriteLine(strWithTabs2);
        Console.WriteLine("Everyone loves V'Hello World\" ");
        Console.WriteLine("C:\\MyApp\\bin\\Debug ");
        Console.WriteLine("All finished.\n\n\n \a");
        Console.WriteLine();
        string myLongString = @"This is a very
                very
                                    very
                                    long string";
        Console.WriteLine(myLongString);
        Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
    }
    
    static void StringComparisonRevised()
    {
        Console.WriteLine("=> String Comparison:");
        string s1 = "Hello!";
        string s2 = "Yo!";
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine("s1 == s2: {0}", s1 == s2);
        Console.WriteLine("s1 != s2: {0}", s1 != s2);
        Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
        Console.WriteLine("s1.CompareTo(s2): {0}", s1.CompareTo(s2));
        Console.WriteLine("s1 and s2 {0}", s1 == "HELLO");
        Console.WriteLine(s1 == "Helloo");
    }
    
    static void StnngEqualitySpecifyingCompareRules (){
        string s1 = "Hello!";
        string s2 = "HELLO!";

        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine();
        Console.WriteLine(
            "Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}",
            s1, s2, s1.Equals(s2));

        Console.WriteLine(
            "Ignore case (OrdinalIgnoreCase): {0}",
            s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(
            "Ignore case (InvariantCultureIgnoreCase): {0}",
            s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

        Console.WriteLine();

        // IndexOf — поиск подстроки
        Console.WriteLine(
            "Default rules: s1={0}, s2={1}, s1.IndexOf(\"E\"): {2}",
            s1, s2, s1.IndexOf("E"));

        Console.WriteLine(
            "Ignore case (OrdinalIgnoreCase): {0}",
            s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(
            "Ignore case (InvariantCultureIgnoreCase): {0}",
            s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));

        Console.WriteLine();
    }
    
    static void FunWithStnngBuilder ()
    {
        Console.WriteLine("=> Using the StringBuilder:");
        StringBuilder sb = new StringBuilder ("**** Fantastic Games ****");
        sb.Append("\n");
        sb.AppendLine("Half Life");
        sb.AppendLine("Morrowind");
        sb.AppendLine("Deus Ex" + "2");
        sb.AppendLine("System Shock");
        Console.WriteLine(sb.ToString());
        sb.Replace("2", " Invisible War");
        Console.WriteLine(sb.ToString());
        Console.WriteLine("sb has {0} chars.", sb.Length);
        Console.WriteLine();
    }


}