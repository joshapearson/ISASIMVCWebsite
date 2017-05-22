using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISASIMVCWebsite.Models
{
	public class EmailMessageAttachment
	{
		public EmailMessageAttachment()
		{
			EmailMessages = new HashSet<EmailMessage>();
		}

		public int EmailMessageAttachmentID { get; set; }
		public byte[] Attachment { get; set; }
		public string FileName { get; set; }

		public virtual ICollection<EmailMessage> EmailMessages { get; set; }
	}
}