using System;
using System.IO;

namespace Umea.se.ExempelApplikation.Utilities.Extensions
{
    public static class ExtensionMethods
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            stream.Position = 0;
            var buffer = new byte[stream.Length];
            for (var totalBytesCopied = 0; totalBytesCopied < stream.Length; )
                totalBytesCopied += stream.Read(buffer, totalBytesCopied, Convert.ToInt32(stream.Length) - totalBytesCopied);
            return buffer;
        }

        public static string UppercaseFirstLetter(this string value)
        {
            if (value.Length <= 0) return value;
            var array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }

    }
}
