using System;

namespace UniversalConverter
{
    class Program
    {
        //գրել ունիվերսալ կոնվերտեր որը կփոխի string-ը ձեր ուզած տիպի

        public static object ChooseTypeForConvert<T>(Converter<T> converter) where T : struct
        {
            object result = null;//Change object
            Console.Write("Input string for convert: ");
            string input = Console.ReadLine();

            try
            {
                result = converter.StringConvert(input);
            }
            catch (InvalidCastException e) { Console.WriteLine(e.Message); }  //remove console
            catch (ArgumentException arg) { Console.WriteLine(arg.Message); } //remove console
            catch (FormatException fm) { Console.WriteLine(fm.Message); }     //remove console
            catch (OverflowException ov) { Console.WriteLine(ov.Message); }   //remove console
            catch (Exception ex) { Console.WriteLine(ex.Message); }           //remove console

            return result;
        }

        static void Main(string[] args)
        {
            Converter<int> converterInt = new Converter<int>();
            Console.WriteLine(ChooseTypeForConvert(converterInt));

            Converter<bool> convertBool = new Converter<bool>();
            Console.WriteLine(ChooseTypeForConvert(convertBool));//and so forth

        }
    }
}
