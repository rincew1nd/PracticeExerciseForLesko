using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_4_ImplicitConversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int16 i16 = 1;
            Int32 i32 = 1;
            double db = 1;

            // Преведение int32 -> int64
            i16 = 132;
            // Преведение Double -> Int16. Потеря дробной части
            i16 = db;
            // Преобразовани Int16 -> Int32. Тип с меньшим максимальным значением к типу с большим максимальным размером
            i32 = i16;
            // Преведение Double -> Int32 Потеря дробной части
            i32 = db;
            // Преобразовани Int32 -> Double. Тип с меньшим максимальным значением к типу с большим максимальным размером
            db = 116;
            // Преобразовани Int32 -> Double. Тип с меньшим максимальным значением к типу с большим максимальным размером
            db = i32;
        }
    }
}
