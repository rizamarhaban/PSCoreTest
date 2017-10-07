using System;
using System.Management.Automation;

namespace pscoretest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                var results = ps.AddScript("Get-Command -CommandType cmdlet New-*").Invoke();

                foreach (var item in results)
                {
                    Console.WriteLine(item.Properties["Name"].Value.ToString());
                }
            }
        }
    }
}
