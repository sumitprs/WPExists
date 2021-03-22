using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPExists.Action
{
    public static class SettingConfig
    {
        public static string USER
        {
            get
            {
                return Properties.Settings.Default.user_name;
            }
            set
            {
                Properties.Settings.Default.user_name = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string PASSWORD
        {
            get
            {
                return Properties.Settings.Default.password;
            }
            set
            {
                Properties.Settings.Default.password = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool LOGGEDIN
        {
            get
            {
                return Properties.Settings.Default.logged_in;
            }
            set
            {
                Properties.Settings.Default.logged_in = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool AUTOFILL_USERNAME
        {
            get
            {
                return Properties.Settings.Default.autofill_username;
            }
            set
            {
                Properties.Settings.Default.autofill_username = value;
                Properties.Settings.Default.Save();
            }
        }
        public static List<string> ProxyIPCollection
        {
            get
            {
                if (Properties.Settings.Default.proxy_ip_collection != null)
                {
                    return Properties.Settings.Default.proxy_ip_collection.Split(',').Select(a=> a).ToList();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                Properties.Settings.Default.proxy_ip_collection = value.Aggregate((x, y) => x + "," + y);
                Properties.Settings.Default.Save();
            }
        }
        public static bool USEPROXY
        {
            get
            {
                return Properties.Settings.Default.use_proxy;
            }
            set
            {
                Properties.Settings.Default.use_proxy = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int REQUEST_BATCH_SIZE
        {
            get
            {
                return Properties.Settings.Default.request_batch_size;
            }
            set
            {
                Properties.Settings.Default.request_batch_size = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string API_BASE_URL
        {
            get
            {
                return Properties.Settings.Default.api_base_url;
            }
            set
            {
                Properties.Settings.Default.api_base_url = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool OPERATION_HASHSET
        {
            get
            {
                return Properties.Settings.Default.operation_hashset;
            }
            set
            {
                Properties.Settings.Default.operation_hashset = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OPERATION_TASK
        {
            get
            {
                return Properties.Settings.Default.operation_task;
            }
            set
            {
                Properties.Settings.Default.operation_task = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OPERATION_ASYNC
        {
            get
            {
                return Properties.Settings.Default.operation_async;
            }
            set
            {
                Properties.Settings.Default.operation_async = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OPERATION_CHROMEDRIVER
        {
            get
            {
                return Properties.Settings.Default.operation_chromedriver;
            }
            set
            {
                Properties.Settings.Default.operation_chromedriver = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool OPERATION_WEBSOCKET
        {
            get
            {
                return Properties.Settings.Default.operation_websocket;
            }
            set
            {
                Properties.Settings.Default.operation_websocket = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
