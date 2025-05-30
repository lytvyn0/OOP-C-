using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public sealed class AppSettings
    {
        private static AppSettings _instance = null;
        private static readonly object _lock = new object();

        public string Language { get; set; }
        public bool DarkModeEnabled { get; set; }

        private AppSettings()
        {
            Language = "uk-UA";
            DarkModeEnabled = false;
        }

       
        public static AppSettings Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AppSettings();
                    return _instance;
                }
            }
        }
    }
}
