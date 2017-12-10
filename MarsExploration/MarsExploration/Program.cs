using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();
            int totalMessage = S.Length / 3;
            int changed = 0;

            for (int message = 0; message < totalMessage; message++)
            {
                if (S[0 + message * 3] != 'S')
                    changed++;
                if (S[1 + message * 3] != 'O')
                    changed++;
                if (S[2 + message * 3] != 'S')
                    changed++;
            }
            Console.WriteLine(changed);
        }
    }
}
