﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OZSK.Client.Model.Abstr
{
    public class ServiceConfig
    {
        public string BaseURL { get; set; }
        public int Port { get; set; }
        public string BasePath { get; set; }
        public string ServiceName { get; set; }
    }

    
}