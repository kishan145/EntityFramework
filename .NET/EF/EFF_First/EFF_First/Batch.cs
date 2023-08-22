using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFF_First
{
    public class Batch
    {
        [Key]
        public string BatchCode { get; set; }

        public string Location { get; set; }
        [Required]
        public int TraineeStrenght { get; set; }
        public int batchCount { get; set; }
        public string batchName { get; set; }


        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2}",this.BatchCode, this.Location, this.TraineeStrenght);
        }
    }
}
