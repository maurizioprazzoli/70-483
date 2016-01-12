using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Loan
{
    public class Program
    {

        public enum Compass
        {
            Noth,
            South,
            East,
            West
        }

        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Person p = new Person
                                                {
                                                    FirstName = "John",
                                                    LastName = "Doe",
                                                    Age = 42
                                                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }
            Console.WriteLine(xml);

            using (StringReader stringReader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }
        }

        [DataContract]
        public class Location
        {
            [DataMember]
            public string Label { get; set; }
            [DataMember]
            public Compass Dircetion { get; set; }
        }

        [Serializable]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }


        void DoWork()
        {
            var location = new Location { Label = "Test", Dircetion = Compass.West };
            Console.WriteLine(WriteObject(location, new DataContractSerializer(typeof(Location))));
        }

        string WriteObject(Location location, XmlObjectSerializer xmlObjectSerializer)
        {
            return "String";
        }



        public class TabDelimitedformatter
        {
            readonly Func<int, char> suffix = col => col % 2 == 0 ? '\n' : '\t';

            public string GetOutput(IEnumerator<string> iterator, int recordSize)
            {
                string output = null;
                for (int i = 1; iterator.MoveNext(); i++)
                {
                    output = output + iterator.Current + suffix(i);
                }
                return output;
            }
        }
    }
}


