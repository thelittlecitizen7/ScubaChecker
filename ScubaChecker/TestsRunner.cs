using MamasChecker.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestsRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            return (T[])serializer.Deserialize(stream);
        }


        public byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
