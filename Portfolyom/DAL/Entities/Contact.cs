﻿namespace Portfolyom.DAL.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Description { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
