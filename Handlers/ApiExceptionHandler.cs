﻿using Sunshine.WebApiLib.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunshine.WebApiLib.Handlers
{
    /// <summary>
    /// 默认Api异常处理器
    /// </summary>
    public class ApiExceptionHandler : IApiExceptionHandler
    {
        public ApiResult Handle(Exception exception)
        {
            return new ApiResult(500, exception.Message);
        }
    }
}
