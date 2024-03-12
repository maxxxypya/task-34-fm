using System;
internal class Program
{
    public static void Main()
    {
        IPrinter[] printer = new IPrinter[4];
        IElGen<int> IntGen = new IntGen();
        IElGen<string> StringGenerator = new StrGen();
        IElGen<double> DoubleGenerator = new DoubGen();
        IElGen<bool> BoolGen = new GeneratorBool();

        printer[0] = new Array1<double>(false, GenGen);
        printer[1] = new Array1<string>(true, StrGen);
        printer[2] = new Array2<int>(false, IntGen);
        printer[3] = new Array2<bool>(true, BoolGen);

        for (int i = 0; i < printer.Length; i++)
        {
            printer[i].WriteArray();
        }
    }
}
