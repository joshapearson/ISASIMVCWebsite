using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class MemberType
	{
		public MemberType()
		{
			Users = new HashSet<User>();
		}

		public int MemberTypeID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }

		public virtual ICollection<User> Users { get; set; }
	}
}