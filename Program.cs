namespace Hex;

public sealed class Program
{
    private static void Usage()
    {
        Console.Error.WriteLine(
            "\n" +
            "hex/hex: Converts hexadecimal to decimal and vice-versa.\n\n" +
            "usage: hex [hex|dec]");

        Environment.Exit(1);
    }

    public static void Main(string[] args)
    {
        if (args.Length < 1)
            Usage();

        foreach (var i in args)
        {
            string arg = i.ToLower();
            if (arg.StartsWith("x"))
                arg = arg.Insert(0, "0");

            string val = String.Empty;
            if (Int64.TryParse(arg, out long result))
                val = String.Format("0x{0:x}", result);
            else if (arg.StartsWith("0x"))
                val = Convert.ToInt64(arg, 16).ToString();
            else
                Usage();

            Console.WriteLine($"{arg}: {val}");
        }
    }
}