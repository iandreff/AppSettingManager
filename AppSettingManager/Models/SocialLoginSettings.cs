using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingManager.Models
{
    public class SocialLoginSettings
    {
        public bool SocialLoginEnabled { get; set; }
        public KeyValueSettings FacebookSettings { get; set; }
        public KeyValueSettings GoogleSettings { get; set; }
    }

    public class KeyValueSettings
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}