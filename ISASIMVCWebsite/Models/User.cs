using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class User
	{
		public User()
		{
			EmailApprovals = new HashSet<EmailApproval>();
			EmailApprovals1 = new HashSet<EmailApproval>();
		}

		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int UserLevelID { get; set; }
		public int SocietyID { get; set; }
		public int? MemberTypeID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleInitial { get; set; }
		public string Email { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public string Firm { get; set; }
		public string Occupation { get; set; }
		public string Spouse { get; set; }
		public string Title { get; set; }
		public decimal? Fee { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public DateTime? DateJoined { get; set; }
		public DateTime? LastUpdated { get; set; }
		public DateTime? DateIdCardIssued { get; set; }
		public DateTime? DatePinIssued { get; set; }
		public DateTime? DateCertificateIssued { get; set; }
		public DateTime? DateHandbookIssued { get; set; }
		public DateTime? DateReinstated { get; set; }
		public DateTime? DateResigned { get; set; }
		public DateTime? DateUpgraded { get; set; }
		public DateTime? DateDeceased { get; set; }
		public DateTime? DatePaid { get; set; }
		public string WebsiteUrl { get; set; }
		public decimal? VoluntaryContribution { get; set; }
		public DateTime? VoluntaryContributionDate { get; set; }
		public bool AutomaticCharge { get; set; }
		public int? PaymentOptionID { get; set; }
		public int? CreditCardTypeID { get; set; }
		public string ResidentialPhone { get; set; }
		public string BusinessPhone { get; set; }
		public string Cell { get; set; }
		public string Fax { get; set; }
		public bool? Active { get; set; }
		public DateTime? ExpirationDate { get; set; }

		public virtual ICollection<EmailApproval> EmailApprovals { get; set; }
		public virtual ICollection<EmailApproval> EmailApprovals1 { get; set; }
		public virtual MemberType MemberType { get; set; }
		public virtual Society Society { get; set; }
	}
}