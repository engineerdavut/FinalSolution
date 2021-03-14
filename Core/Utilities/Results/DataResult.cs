using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            /// BU kod calisirken digeri calismaz ondan dolayi 2 consructor da da grekir atama
            Data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }

    }
}
