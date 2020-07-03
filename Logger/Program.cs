using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //test code
            LogHelper.Log(LogTarget.File, "text to file");

            FileLogger customPath = new FileLogger("customfile.txt");
            customPath.Log("test");

            LogHelper.Log(LogTarget.Console, "console test");

            Console.ReadLine();
        }
    }
}
