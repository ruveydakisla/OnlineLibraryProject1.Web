﻿using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Year { get; set; }
        public int PageNumber { get; set; }

    }
}