///-----------------------------------------------------------------
///   Namespace:      LAB4
///   Class:          Person
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

using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System;
using LAB4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace LAB4
{

    public class Person : IComparable, IEquatable<Person>
    {
        // Properties 
        public string firstName     { get; init; }
        public string lastName      { get; init; }
        public string street        { get; init; }
        public string city          { get; init; }
        public string state         { get; init; }
        public string postalCode    { get; init; }

        // Constructor
        public Person(string firstName, string lastName, string street, string city, string state, string postalCode)
        {
            this.firstName      = firstName;
            this.lastName       = lastName;
            this.street         = street;
            this.city           = city;
            this.state          = state;
            this.postalCode     = postalCode;
        }

        public Person()
        {
            firstName   = String.Empty;
            lastName    = String.Empty;
            street      = String.Empty;
            city        = String.Empty;
            state       = String.Empty;
            postalCode  = String.Empty;
        }
        
        // compare Person values
        public int CompareTo(object? obj)
        {
            Person compPerson = (Person)obj;

            if (this.lastName == compPerson.lastName)
                return -1;
            else if (this.lastName != compPerson.lastName)
                return 1;
            else
                return 0;
        }
        /*
        public override string ToString()
        {
            return
                $"------------------------\n" +
                $"First Name: {firstName}\n" +
                $"Last Name:  {lastName}\n" +
                $"Street:     {street}\n" +
                $"------------------------";
        }*/


        public bool Equals(Person? other)
        {
            if (this.lastName == other.lastName)
                return true;
            else
                return false;
        }  
    }
}

