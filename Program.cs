using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkSixСlinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patients;
            Console.Write($"Введите кол-во пациентов: ");
            patients = Convert.ToInt32( Console.ReadLine() );
            int appointmenTime = 10;
            int minutesInHours = 60;
            int queueTimeHours = patients * appointmenTime / minutesInHours;
            int queueTimeMinutes = patients * appointmenTime % minutesInHours;
            Console.WriteLine($"Вы должны отстоять в очереди {queueTimeHours} " +
                $"часов и {queueTimeMinutes} минут.");
        }
    }
}
