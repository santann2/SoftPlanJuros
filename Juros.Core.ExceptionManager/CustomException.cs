using System;
using System.Net;

namespace Juros.Core.ExceptionManager
{
    public class CustomException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; private set; }

        public string NamespaceClass { get; private set; }

        public string Method { get; private set; }

        public CustomException(string message, HttpStatusCode httpStatusCode, string namespaceClass, string method) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            NamespaceClass = namespaceClass;
            Method = method;
        }

        public static string CustomError(Exception ex)
        {
            string erro = "";
            if (ex.InnerException != null)
                erro = ex.InnerException.Message;
            else
                erro = ex.ToString();

            return erro;
        }

    }

}
