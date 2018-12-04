using System;

namespace UniversalConverter
{
    class Program
    {
        //գրել ունիվերսալ կոնվերտեր որը կփոխի string-ը ձեր ուզած տիպի
      
        public static object ChooseTypeForConvert<T>(Converter<T> converter)where T:struct
        {
            object result = null;
            Console.Write("Input string for convert: ");
           string input = Console.ReadLine();
            result = converter.StringConvert(input);
            return result;

        }

        static void Main(string[] args)
        {
            Converter<int> converter = new Converter<int>();
           
            try
            {
                Console.WriteLine(ChooseTypeForConvert(converter));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            catch (FormatException fm)
            {
                Console.WriteLine(fm.Message);
            }
            catch (OverflowException ov)
            {
                Console.WriteLine(ov.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
