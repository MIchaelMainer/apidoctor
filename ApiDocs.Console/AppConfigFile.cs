﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDocs.ConsoleApp
{
    public class AppConfigFile : ApiDocs.Validation.ConfigFile
    {
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        [JsonProperty("checkServiceEnabledBranches")]
        public string[] CheckServiceEnabledBranches { get; set; }


        public override bool IsValid
        {
            get { return null != Accounts || null != CheckServiceEnabledBranches; }
        }
    }
}
