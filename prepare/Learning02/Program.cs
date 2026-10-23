using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Big Dawg";
        job1._company = "Apple";
        job1._start = "2000";
        job1._end = "2030";

        Job job2 = new Job();
        job2._jobtitle = "Biggest Dawg";
        job2._company = "BigDawgLLC";
        job2._start = "2030";
        job2._end = "2050";

        Resume resume1 = new Resume();
        resume1._name = "Cornelius 'Dawg' Gangster";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job1);
        resume1.Display();
    }
}