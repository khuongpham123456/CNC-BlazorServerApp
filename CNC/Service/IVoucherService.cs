﻿using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CNC.Service
{
    public interface IVoucherService
    {
        IEnumerable<Voucher> getAllVouchers();
        
    }
}
