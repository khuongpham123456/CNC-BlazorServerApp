﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNC.Entities;

namespace CNC.Service
{
    public interface ICustomerService
    {
        Customer GetCustomerFromIdUser(int id);
        Customer GetCustomerFromIdAccount(int id);

    }
}
