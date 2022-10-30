using System;
using System.Collections.Generic;
using System.Text;


public class OnSiteJobOffer : JobOffer
{
    private string city;

    public string City
    {
        get
        {
            return city;
        }

        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
            city = value;
        }
    }

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
        City = city;
    }

    public override string ToString()
    {
        return base.ToString() + "\n"
             + $"City: {city}";
    }
}