using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCustomerService.Models;
public class SparePart
{
    public int SparePartId { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int AmountOfStock { get; set; }
    public decimal Price { get; set; }
}
