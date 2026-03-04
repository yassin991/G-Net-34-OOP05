using AssignmentOOP05.simpleInterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }

        protected decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public decimal PriceAfterTax => Price * 1.14m;

        public bool IsBooked { get; private set; }

        protected Ticket(string movie, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movie;
            Price = price;
        }

        public static int GetTotalTickets() => counter;

   
        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }


        public abstract void Print();


        public abstract object Clone();
    }
}
