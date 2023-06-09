﻿using System;

namespace myBooksAPI.Models.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool IsRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime DateAdded { get; set;}
    }
}
