﻿using BulkyBook1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook1.DataAccess.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category obj);
    }
}
