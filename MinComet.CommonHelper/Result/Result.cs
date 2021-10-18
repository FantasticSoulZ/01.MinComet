using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.Result
{
    public static class Result
    {
        public static object Success(object data,object other=null) {
            BaseResult result = new BaseResult();
            result.Status = true;
            result.Data = data;
            result.Other = other;

            return result;
        }

        public static object Fail(string msg, object other = null,object data=null) {
            BaseResult result = new BaseResult();
            result.Status = false;
            result.Data = data;
            result.Msg = msg;
            result.Other = other;

            return result;
        }
    }
}
