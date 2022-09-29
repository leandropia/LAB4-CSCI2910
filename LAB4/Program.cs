///-----------------------------------------------------------------
///   Namespace:      LAB4
///   Class:          Program
///   Description:    CSCI-2910-201 - LAB 4 - File I/O and Text Ma-
///                   nipulation
///   Author:         NASCIMENTO, LEO              Date:  09.22.2022
///   Notes:          <Notes>
///-----------------------------------------------------------------
///   Revision History: N/A
///   Name:N/A           Date: N/A        Description: N/A
///-----------------------------------------------------------------
///
///

using ConsoleTables;
using LAB4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

public class Program
{
    private static void Main(string[] args)
    {
        var root            = FileRoot.fileRootPath;
        char dirSeparator   = Path.DirectorySeparatorChar;
        var fileCSV         = root + dirSeparator + "Data" + dirSeparator + "data.csv";
        var filePSV         = root + dirSeparator + "Data" + dirSeparator + "data.psv";

        var people = new List<Person>();

        using (var streamReader = new StreamReader(fileCSV))
        {
            while (!streamReader.EndOfStream)
            {
                string  line        = streamReader.ReadLine();
                var     info        = line.Split(",");
                var     firstName   = info[0];
                var     lastName    = info[1];
                var     street      = info[2];
                var     city        = info[3];
                var     state       = info[4];
                var     postalCode  = info[5];

                people.Add(new Person(firstName, lastName, street, city, state, postalCode));
            }
        }

        Console.WriteLine("Sorting entries...");
       
        /*
         var orderByLastName = from p in people
                              orderby p.lastName
                              select p;
        */
       
        people.Sort();

        Console.WriteLine("Creating PSV File");

        using (var streamWriter = new StreamWriter(filePSV, append: false))
        {
            foreach (Person p in people)
            {
                string row = $"{p.firstName}|{p.lastName}|{p.street}|{p.city}|{p.state} |{p.postalCode}";
                streamWriter.WriteLine(row);
                //streamWriter.WriteLine(orderByLastName);
            }
        }

        ConsoleTable table = new ConsoleTable("First Name", "Last Name", "Street", "City", "State", "Postal Code");


        foreach (Person p in people)

            table.AddRow(p.firstName, p.lastName, p.street, p.city, p.state, p.postalCode);


        Console.WriteLine(table);
    }
}