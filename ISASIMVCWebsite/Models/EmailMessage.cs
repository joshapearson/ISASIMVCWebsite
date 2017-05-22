using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class EmailMessage
	{
		public int EmailMessageID { get; set; }
		public DateTime QueueDate { get; set; }
		public string EmailRecipients { get; set; }
		public string EmailSubject { get; set; }
		public string EmailBody { get; set; }
		public string EmailFrom { get; set; }
		public bool Sent { get; set; }
		public bool EmbedAttachmentInEmail { get; set; }
		public int? EmailMessageAttachmentID { get; set; }

		public virtual EmailMessageAttachment EmailMessageAttachment { get; set; }
	}
}