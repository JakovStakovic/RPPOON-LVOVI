using RPPONLV3;
using System.Diagnostics;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dataset x1  = new Dataset("TextFile1.txt");
            Console.WriteLine(x1.StringConcatenationUsingStringBuilder());
        }
    }
}
