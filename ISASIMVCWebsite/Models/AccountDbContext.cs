using ISASIMVCWebsite.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ISASIMVCWebsite.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
			: base("DefaultConnection")
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		public virtual DbSet<Bibliography> Bibliography { get; set; }
		public virtual DbSet<CorporateMember> CorporateMember { get; set; }
		public virtual DbSet<CreditCardType> CreditCardType { get; set; }
		public virtual DbSet<EmailApproval> RegOnlineUserFee { get; set; }
		public virtual DbSet<EmailApproval> EmailApproval { get; set; }
		public virtual DbSet<EmailMessageAttachment> EmailMessageAttachment { get; set; }
		public virtual DbSet<EmailMessage> EmailMessage { get; set; }
		public virtual DbSet<Event> Events { get; set; }
		public virtual DbSet<ForumMagazine> ForumMagazines { get; set; }
		public virtual DbSet<GuideLine> Guidelines { get; set; }
		public virtual DbSet<ISASIUpdate> IsasiUpdate { get; set; }
		public virtual DbSet<MemberType> MemberTypes { get; set; }
		public virtual DbSet<Month> Months { get; set; }
		public virtual DbSet<PaymentOption> PaymentOptions { get; set; }
		public virtual DbSet<Society> Societies { get; set; }
		public virtual DbSet<UserLevel> UserLevels { get; set; }
		public virtual DbSet<User> Users { get; set; }
		//public virtual DbSet<Error> Errors { get; set; }
	}

}