﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Dapper.Core
{
    [Table("tblContact")]
    public class Contact
    {
        public int? ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}