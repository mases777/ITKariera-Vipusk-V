using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
	private readonly Dictionary<string, Category> categories;

	public Controller()
	{
		categories = new Dictionary<string, Category>();
	}

	public string AddCategory(List<string> args)
	{
		string name = args[0];
		categories.Add(name, new Category(name));
		return $"Created Category {name}!";
	}

	public string AddJobOffer(List<string> args)
	{
		string name = args[0];
		Category category = categories[name];
		string jobTitle = args[1];
		string company = args[2];
		double salary = double.Parse(args[3]);
		string type = args[4];
		JobOffer job;
		if (type == "onsite")
		{
			string city = args[5];
			job = new OnSiteJobOffer(jobTitle, company, salary, city);
		}
		else
		{
			bool fullyRemote = bool.Parse(args[5]);
			job = new RemoteJobOffer(jobTitle, company, salary, fullyRemote);
		}
		category.AddJobOffer(job);
		return $"Created JobOffer {jobTitle} in Category {name}!";
	}

	public string GetAverageSalary(List<string> args)
	{
		string name = args[0];
		Category category = categories[name];
		double average = category.AverageSalary();
		return string.Format("The average salary is: {0:F2} BGN", average);
	}

	public string GetOffersAboveSalary(List<string> args)
	{
		string name = args[0];
		double salary = double.Parse(args[1]);
		Category category = categories[name];
		List<JobOffer> jobOffers = category.GetOffersAboveSalary(salary);
		StringBuilder sb = new StringBuilder();
		foreach (JobOffer job in jobOffers)
		{
			sb.AppendLine(job.ToString());
		}

		return sb.ToString();
	}

	public string GetOffersWithoutSalary(List<string> args)
	{
		string name = args[0];
		Category category = categories[name];
		List<JobOffer> jobOffers = category.GetOffersWithoutSalary();
		StringBuilder sb = new StringBuilder();
		foreach (JobOffer job in jobOffers)
		{
			sb.AppendLine(job.ToString());
		}

		return sb.ToString();
	}
}