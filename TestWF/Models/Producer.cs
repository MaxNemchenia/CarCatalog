using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWF.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public ICollection<Mark> Marks { get; set; }
    }
}