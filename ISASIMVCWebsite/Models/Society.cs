using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class Society
	{
		public Society()
		{
			ChildSocieties = new HashSet<Society>();
			Users = new HashSet<User>();
		}

		public int SocietyID { get; set; }
		public string Name { get; set; }
		public string Abbreviation { get; set; }
		public int? ParentSocietyID { get; set; }
		public string Information { get; set; }
		public double? MapX { get; set; }
		public double? MapY { get; set; }
		public bool Enabled { get; set; }

		public virtual ICollection<Society> ChildSocieties { get; set; }
		public virtual Society ParentSociety { get; set; }
		public virtual ICollection<User> Users { get; set; }
	}
}