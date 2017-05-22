using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class CorporateMember
	{
		public int CorporateMemberID { get; set; }
		public string MemberNumber { get; set; }
		public string Name { get; set; }
		public string Website { get; set; }
		public string Country { get; set; }
		public string PrimaryRepEmailAddress { get; set; }
		public string AlternateRepEmailAddress { get; set; }
		public string PrimaryRepName { get; set; }
		public string AlternateRepName { get; set; }
		public string Password { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string BusinessPhone { get; set; }
		public string Fax { get; set; }
		public decimal? Fee { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public string PrimaryRepTitle { get; set; }
	}
}