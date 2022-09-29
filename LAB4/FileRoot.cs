///-----------------------------------------------------------------
///   Namespace:      LAB4
///   Class:          ProjectRoot
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class FileRoot
    {
        public static string fileRootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
