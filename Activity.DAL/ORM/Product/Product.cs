using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.DAL.ORM;
public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public int Stock { get; set; }
    public Guid ActivityId { get; set; }
    [ForeignKey("ActivityId")]
    public Activity Activity { get; set; }
}
