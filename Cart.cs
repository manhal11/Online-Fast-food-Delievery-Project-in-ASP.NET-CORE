using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    internal class Cart
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Item { get; set; }
        public string ApplicationUserId { get;  set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required,MinLength(1)]
        public int Coun { get; set; }
    }
}
