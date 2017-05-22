using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class Bibliography
	{
		public int BibliographyID { get; set; }
		public string Author { get; set; }
		public string CoAuthors { get; set; }
		public string Forb { get; set; }
		public string Issue { get; set; }
		public string Page { get; set; }
		public string Title { get; set; }
		public int PublicationYear { get; set; }
	}
}