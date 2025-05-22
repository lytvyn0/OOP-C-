using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string path = "students.xml";

        Console.WriteLine("=== Групування студентiв за групою ===");

        XDocument xdoc = XDocument.Load(path);
        var groupCounts = xdoc.Descendants("student")
                              .GroupBy(s => (string)s.Attribute("group"))
                              .Select(g => new { Group = g.Key, Count = g.Count() });

        foreach (var group in groupCounts)
        {
            Console.WriteLine($"Група: {group.Group}, Кiлькiсть студентiв: {group.Count}");
        }

        Console.WriteLine("\n=== Середнiй бал кожного студента ===");

        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        XmlNodeList studentNodes = doc.SelectNodes("/students/student");

        foreach (XmlNode student in studentNodes)
        {
            string name = student.SelectSingleNode("name").InnerText;
            XmlNode gradesNode = student.SelectSingleNode("grades");

            var grades = gradesNode.ChildNodes
                                   .Cast<XmlNode>()
                                   .Select(n => int.Parse(n.InnerText))
                                   .ToList();

            double average = grades.Average();
            Console.WriteLine($"{name}: середнiй бал = {average:F2}");
        }
    }
}
