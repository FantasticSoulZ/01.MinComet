using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.Utils
{
    /// <summary>
    /// 加密工具
    /// </summary>
    public static class Encryption
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5Text(string str) {
            using (MD5 md5 = MD5.Create()) {
                byte[] buffer = Encoding.Default.GetBytes(str);
                //开始加密
                byte[] newBuffer = md5.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static string GetRandomStr(int num) {
            if (num <= 0)
                return "";

            byte[] r = new byte[num];
            Random rand = new Random((int)(DateTime.Now.Ticks % 1000000));
            int ran = 0;
            //生成 num 字节原始数据
            for (int i = 0; i < num; i++)
            {
                do
                {
                    ran = rand.Next(48, 122);
                    r[i] = Convert.ToByte(ran);
                }
                while ((ran >= 58 && ran < 64) || (ran >= 91 && ran < 96));
            }
            return Encoding.ASCII.GetString(r);
        }
    }
}
