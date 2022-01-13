//Abstract classes are just like normal classes. However if an abstract class has abstract method, it can not be implemented inside abstract class.
//It can be inherited by other class and implemented later. 

using CSharpAbstractClass.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

HighPaidWorker HighPaidWorker = new HighPaidWorker();
NormalPaidWorker NormalPaidWorker = new NormalPaidWorker();
LowPaidWorker LowPaidWorker = new LowPaidWorker();

Console.WriteLine("High Paid Worker salary: " + HighPaidWorker.CalculateSalary().ToString());
Console.WriteLine("Normal Paid Worker salary: " + NormalPaidWorker.CalculateSalary().ToString());
Console.WriteLine("Low Paid Worker salary: " + LowPaidWorker.CalculateSalary().ToString());

Console.ReadLine();






