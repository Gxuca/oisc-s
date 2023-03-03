using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIStudentSide.Config
{
    public static class ConfigFileHelper
    {
        /// <summary>
        /// 读取配置文件，返回appConfig类
        /// </summary>
        /// <param name="jsonfile">json配置文件,一般在输出目录</param>
        /// <returns>AppConfig实例</returns>
        public static AppConfig InitAppConfig(string jsonfile)
        {
            var jsonConfig = ConfigFileHelper.Readjson(jsonfile);
            var appconfig = new AppConfig();
            #region 设置appconfig
            appconfig.BaseUrl = jsonConfig["baseUrl"].ToString();
            #endregion
            return appconfig;
        }
        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static JObject Readjson(string jsonfile)
        {
            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject jObject = (JObject)JToken.ReadFrom(reader);
                    return jObject;
                }
            }
        }
    }
}
