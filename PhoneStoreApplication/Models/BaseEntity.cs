﻿using System.ComponentModel.DataAnnotations;

namespace PhoneStoreApplication.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}

