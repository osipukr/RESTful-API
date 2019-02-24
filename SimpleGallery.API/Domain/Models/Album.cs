﻿using System.Collections.Generic;

namespace SimpleGallery.API.Domain.Models
{
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ulong NumberOfVisitor { get; set; }
        public IList<Photo> Photos { get; set; } = new List<Photo>();
    }
}