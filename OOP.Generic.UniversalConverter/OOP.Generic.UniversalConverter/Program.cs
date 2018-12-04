using System;

namespace UniversalConverter
{
    class Program
    {
        //գրել ունիվերսալ կոնվերտեր որը կփոխի string-ը ձեր ուզած տիպի

        public static Nullable<T> ChooseTypeForConvert<T>(Converter<T> converter) where T : struct
        {
            T? result = null;
            Console.Write("Input string for convert: ");
            string input = Console.ReadLine();

            try
            {
                result = converter.StringConvert(input);
            }
            catch (InvalidCastException e) { throw new Exception(e.Message); }
            catch (ArgumentException arg) { throw new Exception(arg.Message); }
            catch (FormatException fm) { throw new Exception(fm.Message); }
            catch (OverflowException ov) { throw new Exception(ov.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return result;
        }

        public static void Print(object ob)
        {
            Console.WriteLine(ob.ToString());
        }


        static void Main(string[] args)
        {
            Converter<int> converterToInt = new Converter<int>();
            Converter<bool> convertToBool = new Converter<bool>();
            Converter<decimal> convertToDecimal = new Converter<decimal>();

            try
            {
                Print(ChooseTypeForConvert(converterToInt));
                Print(ChooseTypeForConvert(convertToBool));
                Print(ChooseTypeForConvert(convertToDecimal));
            }
            catch (Exception e)
            {
                Print(e.Message);
            }


        }
    }
}
