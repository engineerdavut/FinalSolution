using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        // get ler cunstructortor icinde set te yapar read only dir.
        // :this(succes) 2 li parametre gelirse 2. consuctora git orada atama ifadesini yap diyoruz.
        // Guzel kullanim.

        public Result(bool success, string message):this(success)
        {
            this.message = message;
        }
        public Result(bool success)
        {
            this.success = success;
        }

        public bool success { get; }

        public string message { get; }
    }
}
