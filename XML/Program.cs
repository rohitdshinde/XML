using System;
using System.Xml;


namespace Assignment06
{
    class Program
    {
        static void ReadAllXmlNodes()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Employee.xml");
            Console.WriteLine("Reading all XML Nodes\n");
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    Console.WriteLine(childNode.InnerText);
                }
                Console.WriteLine();
            }
        }
        static void ReadOneXmlNode(String nodeName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../Employee.xml");
            XmlNode nodeToRead = xmlDoc.SelectSingleNode(nodeName);
            Console.WriteLine("Reading one XML Node\n");

            if (nodeToRead != null)
            {
                foreach (XmlNode childNode in nodeToRead.ChildNodes)
                {
                    Console.WriteLine(childNode.InnerText);
                }

            }
            else
            {
                Console.WriteLine("Node not found !");
            }

        }

        static void InsertNewXmlNodeAndUpdate(String name, int age, int salary)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Employee.xml");
            Console.WriteLine("Inserted XML Node\n");

            XmlElement empolyeeElement = xmlDoc.CreateElement("Employee");
            XmlElement nameElement = xmlDoc.CreateElement("name");
            nameElement.InnerText = name;
            XmlElement ageElement = xmlDoc.CreateElement("age");
            ageElement.InnerText = age.ToString();
            XmlElement salaryElement = xmlDoc.CreateElement("salary");
            salaryElement.InnerText = salary.ToString();

            empolyeeElement.AppendChild(nameElement);
            empolyeeElement.AppendChild(ageElement);
            empolyeeElement.AppendChild(salaryElement);

            XmlNode parentNode = xmlDoc.SelectSingleNode("//Employees");

            if (parentNode != null)
            {

                parentNode.AppendChild(empolyeeElement);
                xmlDoc.Save("Z:\\2nd seml\\Employee.xml");
                Console.WriteLine("Employee Node Inserted Successfully !");
            }
            else
            {
                Console.WriteLine("Parent node not found !");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                // 1) Reading all XML Nodes 
                Program.ReadAllXmlNodes();
                Console.WriteLine("----------------------------");

                // 2) Reading one XMl Node
                Program.ReadOneXmlNode("//Employee");
                Console.WriteLine("----------------------------");

                // 3) Insert new XML Node & Update XML Document
                Program.InsertNewXmlNodeAndUpdate("ROhit", 43, 56000);
                Console.WriteLine("-----------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }




        }
    }
}

