namespace MailClient
{
    public class Mail
    {
        public Mail(string sender, string receiver, string body)
        {
			this.Sender = sender;
			this.Receiver = receiver;
			this.Body = body;
        }
        private string sender;

		public string Sender
		{
			get { return sender; }
			set { sender = value; }
		}
		private string receiver;

		public string Receiver
		{
			get { return  receiver; }
			set {  receiver = value; }
		}
		private string body;

		public string Body
		{
			get { return body; }
			set { body = value; }
		}
        public override string ToString()
        {
            return $"From: {Sender} / To: {Receiver}\nMessage: {Body}";
        }
    }
}
