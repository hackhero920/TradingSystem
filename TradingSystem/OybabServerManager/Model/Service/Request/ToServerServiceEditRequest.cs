﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.Request
{

    public class ToServerServiceEditRequest : ToServerService
    {

        public string Request { get; set; }

    }
}
