using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.simpleInterFace
{
    internal interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
