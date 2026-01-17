using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTittle = "Site Project Manager";
        job1._company = "Church of Jesus Christ";
        job1._startYear = 2025;
        job1._endYear = 2026;
        // job1.DisplayJobInformation();


        Job job2 = new Job();
        job2._jobTittle = "Chief Technical Officer";
        job2._company = "Ministry of Housing";
        job2._startYear = 2016;
        job2._endYear = 2024;
        // job2.DisplayJobInformation();

        Resume resume = new Resume();
        resume._name = "Udoeyen OKON";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayNameAndJob();

    }

}
