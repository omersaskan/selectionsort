using System;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] sayilar = {1, 4, 2, 3, 10, 5, 6,12};
            int temp;
            int min;
            for(int i=0; i<sayilar.Length-1; i++)
            {
                min=i;
                for(int j=i; j<sayilar.Length; j++)
                {
                    if (sayilar[j] < sayilar[min]) min=j;
                }
                temp=sayilar[i];
                sayilar[i]=sayilar[min];
                sayilar[min]=temp;
            }

            foreach (var dd in sayilar)
            {
                Console.WriteLine(dd);
            }

        }
    }
}