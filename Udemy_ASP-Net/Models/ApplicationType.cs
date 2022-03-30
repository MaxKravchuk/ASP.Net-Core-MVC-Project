using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASP_Net.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
