﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Geder { get; set; }
        public int age { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
