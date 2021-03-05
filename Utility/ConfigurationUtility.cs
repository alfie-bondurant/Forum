using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Utility
{
    public class ConfigurationUtility
    {
        public static string DateTimeFormat() {

            //TODO : load it from webconfig
            return "dd.MM.yyyy HH:mm";
        }
    }
}