using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int counter = 0;
            int index = 0;
            int[] cassiers = new int[n];

            for (int j = 0; j < n; j++)
            {
                cassiers[j] = customers[j];
            } // первые n покупателей заняли кассы
            index = n - 1;
            
            while(true) 
            {
                for (int j = 0; j < n; j++)
                {
                    cassiers[j] -= 1;
                    counter += 1;
                    if (cassiers[j] == 0)
                    {
                        if (index >= customers.Length - 1 && cassiers.Max() == 0)
                        {
                            while(counter % n != 0)
                            {
                                counter += 1;
                            }
                            //Console.WriteLine("customers = {0}", string.Join(", ", customers));
                            //Console.WriteLine("cassiers = {0}", n);
                            //Console.WriteLine("result = {0}\n", (counter / n));
                            return counter / n;
                        }
                        else if (index < customers.Length - 1)
                        {
                            index += 1;
                            cassiers[j] = customers[index];
                        }
                    }
                }
            }
        }

    }
}
