using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
			this.Capacity = capacity;
			inbox = new List<Mail> ();
			archive = new List<Mail> ();
        }
        private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}
		private List<Mail> inbox;

		public List<Mail> Inbox
		{
			get { return inbox; }
			set { inbox = value; }
		}
		private List<Mail> archive;

		public List<Mail> Archive
		{
			get { return archive; }
			set { archive = value; }
		}
		public void IncomingMail(Mail mail)
		{
			if (Inbox.Count < this.Capacity)
			{
				Inbox.Add(mail);
			}
		}
		public bool DeleteMail(string sender)
		{
            foreach (var item in inbox)
            {
                if (item.Sender == sender)
                {
                    inbox.Remove(item);
                    return true;
                }
            }
            return false;
		}
		public int ArchiveInboxMessages()
		{
			int mailsReturned = 0;
			for (int i = 0; i < inbox.Count; i++)
			{
				Archive.Add(inbox[i]);
                mailsReturned++;
            }
			inbox.Clear();
			return mailsReturned;
		}
		public string GetLongestMessage()
		{
			return inbox.MaxBy(m => m.Body).ToString();
		}
		public string InboxView()
		{
            StringBuilder result = new StringBuilder();
			result.AppendLine("Inbox:");
			foreach (var item in inbox)
			{
				result.AppendLine(item.ToString());
			}
			return result.ToString().Trim();
        }
    }
}
