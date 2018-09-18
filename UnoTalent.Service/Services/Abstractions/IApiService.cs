﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnoTalent.Service.Services.Abstractions
{
    public interface IApiService<T>
    {
        List<T> GetAll();

        T GetById(long id);
        int Create(T item);
        T Delete(long id);
        T Update(long id, T item);
    }
}