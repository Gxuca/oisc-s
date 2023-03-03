using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSIStudentSide.Http;

/// <summary>
/// 基本请求体类，用于RestClient
/// </summary>
public class BaseRequest
{
    public Method Method { get; set; }
    /// <summary>
    /// 验证身份的凭证
    /// </summary>
    public string Token { get; set; }
    public string Route { get; set; }
    /// <summary>
    /// 默认为Json
    /// </summary>
    public string ContentType { get; set; } = "application/json";
    public object Parameter { get; set; }
}
