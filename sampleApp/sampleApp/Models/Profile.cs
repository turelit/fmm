using System;
using System.Collections.Generic;
using System.Text;

namespace sampleApp.Models
{
    public class Profile
    {
        public Guid id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int accessLevel { get; set; }

    }
}
