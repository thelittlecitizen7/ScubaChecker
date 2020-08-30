using MamasChecker.Abstract;
using System;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlCustomSerializer<TestCase> xmlCustomSerializer = new XmlCustomSerializer<TestCase>();

            var testCases = new TestCase[2];
            testCases[0] = new TestCase { TestContent = "amit", Id = 13 };
            testCases[1] = new TestCase { TestContent = "ariel", Id = 13 };

            ISerializerFactory serializerFactory = new SerializerFactory();
            ISerializer<TestCase> serializer = serializerFactory.CreateSerializer<TestCase>();
            ITestsRunner<TestCase> derializer = serializerFactory.CreateDeserializer<TestCase>();

            var streamSerializeObject = serializer.Serialize(testCases);

            var streamDerializeObject = derializer.Deserialize(streamSerializeObject);

        }
    }
}
