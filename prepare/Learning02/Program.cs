using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web seveloper";
        job1._company = "Web help";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "BBD";
        job2._startYear = 2022;
        job2._endYear = 2023;

        theResume Resume = new theResume();
        
        Resume._Name = "Joshua Givens";

        Resume._jobs.Add(job1);
        Resume._jobs.Add(job2);

        Resume.Display();

    }
}