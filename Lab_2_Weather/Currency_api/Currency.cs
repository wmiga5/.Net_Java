using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Weather_api
{




    [Table ("Currencies")]
    public class Currency
    {
       public int Id {  get; set; }
       public required string Tag {  get; set; }
       public required float Exchange {  get; set; }

        public required double timestamp_number {  get; set; }

        public DateTime ConvertTimestampToDateTime()
        {
            // Tworzymy czas od początku epoki Unix (1 stycznia 1970 roku)
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Dodajemy wartość timestampu jako liczbę sekund do czasu początkowego
            DateTime dateTime = epoch.AddSeconds(timestamp_number);

            return dateTime;
        }

        public Currency() { Id= 0; Tag = "NON";Exchange = -1;timestamp_number = 0; }
        public Currency(int id,string tag,float exchange,double time) { Id = id; Tag = tag; Exchange = exchange;timestamp_number = time; }
        public override string ToString()
        {
            return $"{Tag},\t:{Exchange}\t{this.ConvertTimestampToDateTime().ToString()}\n";
        }
    }
}
