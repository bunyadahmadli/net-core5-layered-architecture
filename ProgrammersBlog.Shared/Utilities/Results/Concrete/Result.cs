using System;
using System.Collections.Generic;
using System.Text;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
   public class Result:IResult
    {
        private readonly ResultStatus _resultStatus;
        private readonly string _message;
        private readonly Exception _exception;

        public Result(ResultStatus resultStatus)
        {
            _resultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string message)
        {
            _resultStatus = resultStatus;
            _message = message;
        }
        public Result(ResultStatus resultStatus, string message,Exception exception)
        {
            _resultStatus = resultStatus;
            _message = message;
            _exception = exception;
        }
        public ResultStatus ResultStatus { get;  }
        public string Message { get;  }
        public Exception Exception { get;  }
    }
}
