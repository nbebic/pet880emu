using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PET880asm
{
    static class Program
    {
        static void Main(string[] args)
        {   
            if (args.Length < 1)
            {
                PrintHelp();
                return;
            }

            var wd = Environment.CurrentDirectory;
            if (wd[wd.Length - 1] != '\\') wd = wd + "\\";
            string inFile = wd + args[0];
            string outFile;
            if (args.Length >= 2)
            {
                outFile = wd + args[1];
            }
            else
            {
                outFile = Path.ChangeExtension(inFile, "bin");
            }
            try
            {
                var asm = new Assembler(inFile, outFile);
                asm.Translate();
                asm.ResReferences();
                asm.GenerateOutput();
                Console.WriteLine("Compilation successful");
            }
            catch (CompilationException ex)
            {
                Console.WriteLine("Error during assembly @[{0}:{1}]: {2}", ex.Line, ex.Column, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error thrown: {0}", ex);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine(
@"usage:  PET880asm in_file [out_file]"
);
        }

        public static bool In<T>(this T val, T low, T high) where T : IComparable
        {
            return val.CompareTo(low) >= 0 && val.CompareTo(high) <= 0;
        }
    }
}
