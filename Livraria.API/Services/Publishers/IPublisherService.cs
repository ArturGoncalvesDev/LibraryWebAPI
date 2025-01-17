﻿using Livraria.API.Models;

namespace Livraria.API.Services.Publishers
{
    public interface IPublisherService
    {
        Publisher PublisherCreate(Publisher model);
        Publisher PublisherUpdate(int publisherId, Publisher model);
        Publisher PublisherDelete(int publisherId);
    }
}
