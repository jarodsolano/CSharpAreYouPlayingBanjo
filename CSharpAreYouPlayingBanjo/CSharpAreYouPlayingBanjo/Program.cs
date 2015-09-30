using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpAreYouPlayingBanjo
{
    class Program
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if (name[0].Equals('r') || name[0].Equals('R'))
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }

        static void Main(string[] args)
        {
            Debug.WriteLine(AreYouPlayingBanjo("ray"));
        }

    }
}
