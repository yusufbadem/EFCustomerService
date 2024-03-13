using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCustomerService.Models;
public class Invoice
{
    public int InvoiceId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal TotalPrice { get; set; }
    public int ServiceId { get; set; }
    [ForeignKey("ServiceId")]
    public ServiceRecord ServiceRecord { get; set; }
}
