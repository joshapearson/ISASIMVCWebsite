using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class ForumMagazine
	{
		public int ForumMagazineID { get; set; }
		public int PublicationYear { get; set; }
		public int StartMonth { get; set; }
		public int EndMonth { get; set; }
		public string Filepath { get; set; }

		public virtual Month Month { get; set; }
		public virtual Month Month1 { get; set; }
	}

	public class Month
	{
		public Month()
		{
			ForumMagazines = new HashSet<ForumMagazine>();
			ForumMagazines1 = new HashSet<ForumMagazine>();
		}

		public int MonthID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ForumMagazine> ForumMagazines { get; set; }
		public virtual ICollection<ForumMagazine> ForumMagazines1 { get; set; }
	}

}