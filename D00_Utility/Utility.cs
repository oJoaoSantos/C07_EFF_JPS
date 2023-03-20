using System;
using System.Text;

namespace D00_Utility
{
    public static class Utility
    {
        public static void SetUniCodeConsole() // Console Encoding (prepare console to recive special characters)
        {
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

            Console.OutputEncoding = Encoding.UTF8;                 // Using System.Text 

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
        }

        public static void WriteTitle(string title)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 50));
        }

        public static void WriteSubTitle(string subtitle)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(subtitle.ToUpper());
            Console.WriteLine(new string('-', 30));
        }

        public static void TerminateConsole()
        {
            Console.Write("\n\nPrime qualquer tecla para saíres.");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool ValidateNumber(double value)
        {
            // v1 não otimizado

            //bool recived = false;
            //if (value == 0)
            //{
            //    recived = true; 
            //}
            //return recived;

            // v2 Operador trenário

            // return value == 0 ? true : false;

            // v3 Mais otimizado

            return value != 0;
        }

        public static bool ValidateStringDouble(string value)
        {
            return double.TryParse(value, out double valueConverted);
        }

        public static bool ValidateStringInt(string value)
        {
            return int.TryParse(value, out int valueConverted);
        }

        public static bool ValidateNumberDouble(string value)
        {

            double valueConverted;

            return double.TryParse(value, out valueConverted) && valueConverted != 0;

        }

        internal static void TestInternal()
        {
            Console.WriteLine("TestInternal");
        }

        public static void BlockSeparator(int enters)
        {
            Console.WriteLine(new string('\n', enters));
        }
    }
}
