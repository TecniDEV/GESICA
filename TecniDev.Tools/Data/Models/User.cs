﻿namespace TecniDev.Tools.Data.Models
{
    public class User
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public virtual Role? Role { get; set; }
    }
}
