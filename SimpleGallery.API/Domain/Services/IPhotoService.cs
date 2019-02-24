﻿using SimpleGallery.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleGallery.API.Domain.Services
{
    public interface IPhotoService
    {
        Task<IEnumerable<Photo>> ListAsync();
    }
}