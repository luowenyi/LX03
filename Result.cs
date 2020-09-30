using Renci.SshNet.Messages;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class Result<T>
    {
        public int Code = 1;
        public string msg = "";
        public T res = default(T);
        public static Result Ok(T result) 
        {
            return new Result() { res = result };
        }
        public static Result Ok(string messago, T Result = default(T)) 
        {
            return new Result() { msg = messago, res = Result };
        }
        public static Result Err(string messago)
        {
            return new Result() { Code = -1, msg = messago };
        }
    }
}
public class Result : Result<dynamic>
{
}
