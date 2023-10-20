using System;

namespace Massive1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArr = new int[10];
            Console.WriteLine("Введите размер массива");
            int lenght = Convert.ToInt32(Console.ReadLine());
            
            Array.Resize(ref MyArr,lenght);
            for (int i = 0; i < lenght; i++)
            {
                MyArr[i] = i;
                Console.WriteLine("{0}.{1}", i + 1, MyArr[i]);
            }
            Console.WriteLine("Введите c какой позиции начинать замену элементов массива, число должно быть меньше {0} ",lenght);
            int k = Convert.ToInt32(Console.ReadLine());
            int[] mass2 = new int[0];
            string s = "";
            int count = 0;
           while (s!="S"||s!="s")
            {
                Console.WriteLine("Введие новое число для массива");
                s = Console.ReadLine();
                Array.Resize(ref mass2,mass2.Length +1);
                if (s == "S" || s == "s")
                {
                    break;
                }
                 else mass2[count]= Convert.ToInt32(s);
                count++;
            }
            Array.Resize(ref MyArr, lenght+count);
            int countk = 1;
            for (int i = lenght-1; k-1<i; i--)
            {
                
                (MyArr[i], MyArr[lenght + count - countk]) = (MyArr[lenght + count - countk], MyArr[i]);
                countk++;
            }
            for (int i = 0; i < count; i++)
            {
                (MyArr[k + i], mass2[i]) = (mass2[i], mass2[i]);
            }
            for (int i = 0; i < MyArr.Length; i++)
            {
                
                Console.WriteLine("{0}.{1}", i + 1, MyArr[i]);
            }
        }
    }
}
