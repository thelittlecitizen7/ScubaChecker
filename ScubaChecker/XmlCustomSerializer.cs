using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class XmlCustomSerializer<T> : ISerializer<T>
    {


        public Stream Serialize(T[] testsToSerialize)
        {
            string path = @"C:\Users\123\source\repos\ScubaChecker\ScubaChecker\xmlObjectSerliazation.xml";

            XmlSerializer writer = new XmlSerializer(testsToSerialize.GetType());
            StreamWriter fileWrite = new StreamWriter(path);
            writer.Serialize(fileWrite, testsToSerialize);
            fileWrite.Close();

            FileStream fileStream = File.OpenRead(path);

            return fileStream;
        }
    }
}

