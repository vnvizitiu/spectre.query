﻿using System.ComponentModel.DataAnnotations;

namespace Spectre.Query.Tests.Data
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }
    }
}
