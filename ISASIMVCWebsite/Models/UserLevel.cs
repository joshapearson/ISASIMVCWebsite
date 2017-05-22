using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class UserLevel
	{
		public int UserLevelID { get; set; }
		public string Description { get; set; }
		public int? Priority { get; set; }
	}
}