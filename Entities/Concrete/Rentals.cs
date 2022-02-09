using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Rentals : IEntity
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int RentDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
