using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class Event
	{
		public int EventID { get; set; }
		public string Header { get; set; }
		public string About { get; set; }
		public string Filepath { get; set; }
	}
}