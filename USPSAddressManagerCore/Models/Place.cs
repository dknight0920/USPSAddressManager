using System;

namespace USPSAddressManagerCore.Models
{
    public class Place
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime? Date { get; private set; }

        public Place
        (
            int id,
            string name,
            DateTime? date
        )
        {
            Id = id;
            Name = name;
            Date = date;
        }
    }
}
