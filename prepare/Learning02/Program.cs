using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Audio Engineer";
        job1._company = "BYU-I";
        job1._startYear = 2021;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "TruGrow";
        job2._jobTitle = "Intern";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "John Smith";

        myResume.DisplayResume();
    }
}