using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWF.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public string MarkName { get; set; }
        public int? ProducerId { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}