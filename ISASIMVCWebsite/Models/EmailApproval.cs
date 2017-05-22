using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class EmailApproval
	{
		public int EmailApprovalID { get; set; }
		public int? ApprovedByUserID { get; set; }
		public string SocietyRecipientIDs { get; set; }
		public bool Approved { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public string AttachmentFilepath { get; set; }
		public DateTime EmailApprovalCreated { get; set; }
		public int? FromUserID { get; set; }
		public bool EmbedAttachmentInEmail { get; set; }

		public virtual User ApprovedByUser { get; set; }
		public virtual User FromUser { get; set; }
	}
}