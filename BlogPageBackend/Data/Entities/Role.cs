﻿using System.ComponentModel.DataAnnotations;

namespace BlogPageBackend.Data.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
