using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Lead Manager";
        job1._company = "Tommy's Express";
        job1._startYear = 2026;
        job1._endYear = 1234;

        Job job2 = new Job();

        job2._jobTitle = "Fryer";
        job2._company = "McDonalds";
        job2._startYear = 2026;
        job2._endYear = 1234;

        Resume myResume = new Resume();

        myResume._name = "Adam Egbert";

        myResume._jobs.Add(job1);

        myResume._jobs.Add(job2);

        myResume.Display();

    }
}