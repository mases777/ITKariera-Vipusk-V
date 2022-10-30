using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
    private bool fullyRemote;

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
        FullyRemote = fullyRemote;
    }

    public bool FullyRemote
    {
        get
        {
            return fullyRemote;
        }
        set
        {
            fullyRemote = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + "\n"
             + $"Fully Remote: " + (fullyRemote ? "yes" : "no");
    }
}