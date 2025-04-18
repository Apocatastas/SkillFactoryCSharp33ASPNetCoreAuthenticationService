﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using AuthentificationService.PLL.Exceptions;

namespace AuthentificationService.PLL.Handlers
{
    public class ExceptionHandler : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = "Произошла кастомная ошибка";

            if (context.Exception is CustomException)
            {
                message = context.Exception.Message;
            }

            context.Result = new BadRequestObjectResult(message);
        }
    }
}
