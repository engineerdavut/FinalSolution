using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        // Succes basarılı mı değil mi? 
        bool success { get; }

        string message { get; }
    }
}
