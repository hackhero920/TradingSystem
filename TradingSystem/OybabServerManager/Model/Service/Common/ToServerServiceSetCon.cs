﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.Common
{

    public class ToServerServiceSetCon : ToServerService
    {

        public string Config { get; set; }


        public long AdminId { get; set; }
    }
}
