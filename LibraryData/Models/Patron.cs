using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryData.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TalephoneNumber { get; set; }
        public virtual List<LibraryCard> LibraryCard { get; set; }

        public LibraryBranch HomeLibraryBranch { get; set; }

    }


}
