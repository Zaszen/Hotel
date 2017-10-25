using AppHotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppHotel.CodeFirst
{
    public class HotelContext:DbContext
    {
        public DbSet<Piece> EntityPiece { get; set; }

    }
}
