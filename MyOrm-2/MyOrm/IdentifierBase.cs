using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrm
{
    public class IdentifierBase
    {
        [Key]
        public int Id { get; set; }
    }
}
