using System;
using System.Collections.Generic;
using System.Linq;
using TagHelpersAndViewComponents.Models;

namespace TagHelpersAndViewComponents.Services
{
	public interface IUserVisitsHistoryService
	{
		IEnumerable<UserVisit> GetLastUserVisits(int historyDepth);
	}

	public class UserVisitsHistoryService : IUserVisitsHistoryService
	{
		public IEnumerable<UserVisit> GetLastUserVisits(int historyDepth)
		{
			return new List<UserVisit>()
			{
				new UserVisit()
				{
					VisitTime = new DateTime(2016, 2, 8, 13, 30, 0),
					User = new ApplicationUser() { UserName = "Robert" }
				},
				new UserVisit()
				{
					VisitTime = new DateTime(2016, 2, 8, 13, 23, 0),
					User = new ApplicationUser() { UserName = "Karel" }
				},
				new UserVisit()
				{
					VisitTime = new DateTime(2016, 2, 8, 13, 21, 0),
					User = new ApplicationUser() { UserName = "Martin" }
				},
				new UserVisit()
				{
					VisitTime = new DateTime(2016, 2, 8, 13, 20, 0),
					User = new ApplicationUser() { UserName = "Robert" }
				}
			}.Take(historyDepth);
		}
	}

	public class UserVisit
	{
		public DateTime VisitTime { get; set; }
		public ApplicationUser User { get; set; }
	}
}