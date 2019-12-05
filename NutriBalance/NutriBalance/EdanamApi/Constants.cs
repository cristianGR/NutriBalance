using System;
using System.Collections.Generic;
using System.Text;

namespace NutriBalance.EdanamApi
{
    class Constants
    {
        public static string Endpoint = "https://test-es.edamam.com/api/nutrition-data?";
        public static string APP_ID = "app_id=0fa3d79a";
        public static string API_KEY = "&app_key=6a572219ef49e1f79f81f89e2b4b43d0";
        public static string EdanamAPIEndPoind = Endpoint + APP_ID + API_KEY;
    }
}
