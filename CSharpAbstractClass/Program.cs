//Abstract classes are just like normal classes. However if an abstract class has abstract method, it can not be implemented inside abstract class.
//It can be inherited by other class and implemented later. 

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

HighPaidWorker HighPaidWorker = new HighPaidWorker();
NormalPaidWorker NormalPaidWorker = new NormalPaidWorker();
LowPaidWorker LowPaidWorker = new LowPaidWorker();

Console.WriteLine("High Paid Worker salary: " +   HighPaidWorker.CalculateSalary().ToString());
Console.WriteLine("Normal Paid Worker salary: " + NormalPaidWorker.CalculateSalary().ToString());
Console.WriteLine("Low Paid Worker salary: " +    LowPaidWorker.CalculateSalary().ToString());

Console.ReadLine();



public class HighPaidWorker : Worker
{
    public override double CalculateSalary()
    {
        return (2000 * 2);
    }
}

public class LowPaidWorker : Worker
{
    public override double CalculateSalary()
    {
        return (2000 * 1);
    }
}

public class NormalPaidWorker : Worker
{
    public override double CalculateSalary()
    {
        return (2000 * 1.5);
    }
}
public abstract class Worker
{
    public string Name { get; set; }

    public abstract double CalculateSalary();

}