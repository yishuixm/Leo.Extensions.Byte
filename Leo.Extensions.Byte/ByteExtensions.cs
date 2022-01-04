using System;
using System.Linq;
using System.Text;

namespace Leo.Extensions
{
    public static class ByteExtensions
    {

        public static byte[] GetBytes(this short value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static short GetShort(this byte[] bytes)
        {
            return BitConverter.ToInt16(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this ushort value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static ushort GetUShort(this byte[] bytes)
        {
            return BitConverter.ToUInt16(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this int value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static int GetInt(this byte[] bytes)
        {
            return BitConverter.ToInt32(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this uint value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static uint GetUInt(this byte[] bytes)
        {
            return BitConverter.ToUInt32(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this long value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static long GetLong(this byte[] bytes)
        {
            return BitConverter.ToInt64(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this ulong value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static ulong GetULong(this byte[] bytes)
        {
            return BitConverter.ToUInt64(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytes(this bool value)
        {
            return BitConverter.GetBytes(value).Reverse().ToArray();
        }
        public static bool GetBoolean(this byte[] bytes)
        {
            return BitConverter.ToBoolean(bytes.Reverse().ToArray());
        }
        public static byte[] GetBytesFromUTF8(this string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }
        public static string GetUTF8FromBytes(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
        public static string GetBase64String(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }
        public static byte[] FromBase64String(this string base64)
        {
            return Convert.FromBase64String(base64);
        }
        public static string GetHexString(this byte[] bytes)
        {
            return BitConverter.ToString(bytes, 0, bytes.Length);
        }
        public static byte[] FromHexString(this string hex, char separator = '-')
        {
            string[]? hexs = null;
            if (hex.Contains(separator))
            {
                hexs =  hex.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            }
            else if(!hex.Contains(separator) && hex.Length % 2 != 0)
            {
                hexs = new string[hex.Length / 2];
                hex = $"0{hex}";
                for (int i = 0; i < hexs.Length; i += 2)
                {
                    hexs[i] = $"{hex[i * 2]}{hex[i * 2 + 1]}";
                }
            }

            if (hexs != null)
            {
                var bytes = new byte[hexs.Length];

                for(int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(hexs[i], 16);
                }

                return bytes;
            }


            return new byte[] { };
        }
    }
}
