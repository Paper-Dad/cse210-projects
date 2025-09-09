using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._compnay = "Microsoft";
        job1._jobTitle = "Programmer";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Programmer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Job.display();
    }
}