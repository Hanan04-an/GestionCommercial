using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
    
}
