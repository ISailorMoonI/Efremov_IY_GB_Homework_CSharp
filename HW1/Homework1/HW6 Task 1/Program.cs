using System;
using System.Diagnostics;
using System.ComponentModel;


namespace HW6_Task_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                Console.WriteLine(@"{0} | ID: {1} | Status {2} | ",
                process.ProcessName, process.Id, process.Responding);
                
            }
            Console.WriteLine("If you want kill process by name type 1, if you want kill by id type 2");
            int caseSwitch = Convert.ToInt32 (Console.ReadLine());
            
            switch(caseSwitch)
            {
                case 1:
                    Console.WriteLine("Enter proccess name");
                    string procname = Console.ReadLine();
                    foreach (var process in Process.GetProcessesByName(procname))
                        try
                    {
                        process.Kill();
                        Console.WriteLine("Process Killed");
                    }
                    catch
                    {
                            Console.Write("\nЧто-то пошло не так:(");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Process ID");
                    int processID = int.Parse(Console.ReadLine());
                    try
                    {
                        Process procId = Process.GetProcessById(processID);
                        procId.Kill();
                        Console.WriteLine("Process Killed");
                    }
                    catch
                    {
                        Console.Write("\nЧто-то пошло не так:(");
                    }
                    break;
            }
           
            
        }
    }
}


