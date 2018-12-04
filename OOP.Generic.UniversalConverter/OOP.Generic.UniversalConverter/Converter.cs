using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace UniversalConverter
{
    class Converter<T>where T:struct
    {
       
        public  T? StringConvert( string inputValue) 
        {
            T? result = null;//T cann be  Nullable<T> type
           
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Boolean:
                    result = (T)(object)Convert.ToBoolean(inputValue);
                    break;
                case TypeCode.Int16:
                    result = (T)(object)char.Parse(inputValue);
                    break;
                case TypeCode.Int32:
                    result = (T)(object)Convert.ToInt32(inputValue);
                    break;
                case TypeCode.Int64:
                    result = (T)(object)long.Parse(inputValue);
                    break;
                case TypeCode.Single:
                    result = (T)(object)Convert.ToSingle(inputValue);
                    break;
                case TypeCode.Double:
                    result = (T)(object)Convert.ToDouble(inputValue);
                    break;
                case TypeCode.Decimal:
                    result = (T)(object)Convert.ToDecimal(inputValue);
                    break;
                default:
                    throw new Exception("Conversion error,no suitable type");
            }
            return result;
        }

     
    }
}
