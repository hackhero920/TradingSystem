﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.Member
{

    public class ToClientServiceGetMember : ToClientService
    {

        public bool Result { get; set; }

        public string Members { get; set; }
    }
}
