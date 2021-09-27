using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            FourProcess fourProcess = new FourProcess();
            fourProcess.gatherIt(5, 6);
            fourProcess.gatherIt(6, 9);
        }
    }
}
