﻿namespace WebApiCoder.Controllers
{
    public class ConfigController
    {
           public string connectionstring { get; set; }
           public ConfigController(string connectionstring)
            {
                this.connectionstring = connectionstring;
            }

    }
}
