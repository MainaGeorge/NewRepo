﻿using Library.Data;

namespace Library.Services.IRepository
{
    public interface IUserRepository  : IRepository<AppUsers>
    {
        AppUsers GetById(string id);
    }
}
