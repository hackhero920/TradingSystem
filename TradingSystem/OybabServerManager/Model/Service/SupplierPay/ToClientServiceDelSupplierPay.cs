﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.SupplierPay
{

    public class ToClientServiceDelSupplierPay : ToClientService
    {

        public bool Result { get; set; }

        public string Supplier { get; set; }
    }
}
