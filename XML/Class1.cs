//using System.Xml;

//namespace XML
//{
//    class XML1
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                XmlDocument xmlDoc = new XmlDocument();
//                xmlDoc.Load("../../Employee.xml");

//                foreach (XmlNode childnode in xmlDoc.SelectNodes("/Employees/Employee"))

//                {
//                    Console.WriteLine("Name: {0} city:{1} salary:{2}",
//                        childnode["Name"].InnerText,
//                        childnode["City"].InnerText,
//                        childnode["Salary"].InnerText);
//                }
//                Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.ReadKey();
//            }


//        }
//    }
//}
