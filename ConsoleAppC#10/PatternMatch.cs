using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppC_10
{
    internal class PatternMatch
    {
        public bool PerformOperation(string operation) =>
            operation switch
            {
                "SystemTest" => SystemTest("SystemTest"),
                _ => throw new Exception("Invalid string value for command"),
            };

        public static bool SystemTest(string input)
        {
            Console.WriteLine(input);
            return true;
        }
    }
}
