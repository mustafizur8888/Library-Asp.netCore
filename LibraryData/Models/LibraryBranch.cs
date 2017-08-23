using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class LibraryBranch
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30,ErrorMessage = "Limit branch name to 30 charecters.")]
        public string Name { get; set; }

        public string Address { get; set; }
        [Required]
        public string Telephone { get; set; }

        public string Description { get; set; }
        public DateTime OpenDate  { get; set; }
        public IEnumerable<Patron> Patrons { get; set; }
        public IEnumerable<LibraryAsset> LibraryAssets { get; set; }
        public string ImageUrl { get; set; }
    }
}