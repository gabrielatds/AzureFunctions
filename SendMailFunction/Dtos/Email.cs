using System.Collections.Generic;

namespace SendMailFunction.Dtos
{
    public class Email
    {
        public IList<string> To { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public IList<Attachments> Attachments { get; set; }
    }
}
