using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    private string name;
    private List<JobOffer> jobOffers;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }

    public Category(string name)
    {
        Name = name;
        jobOffers = new List<JobOffer>();
    }

    public void AddJobOffer(JobOffer offer)
    {
        jobOffers.Add(offer);
    }

    public double AverageSalary()
    {
        if (jobOffers.Count == 0)
            return 0;
        return jobOffers.Average(x => x.Salary);
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers.OrderByDescending(x => x.Salary).Where(x => x.Salary >= salary).ToList();
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers.Where(x => x.Salary == 0).ToList();
    }

    public override string ToString()
    {
        return $"Category {name}\n" +
               $"Total Offers: {jobOffers.Count}";
    }
}