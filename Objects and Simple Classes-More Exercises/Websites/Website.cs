namespace Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Website
    {
        private string host;
        private string domain;
        private List<string> queries;

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public List<string> Queries
        {
            get { return queries; }
            set { queries = value; }
        }
     }
}
