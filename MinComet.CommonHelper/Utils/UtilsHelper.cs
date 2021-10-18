using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.Utils
{
    public static class UtilsHelper
    {
        public static string GetMD5Text(string str) {
            return Encryption.GetMD5Text(str);
        }

        public static string GetRandomStr(int num) {
            return Encryption.GetRandomStr(num);
        }
    }
}
