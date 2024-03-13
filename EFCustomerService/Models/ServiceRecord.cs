using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCustomerService.Models;
public class ServiceRecord
{
    [Key]
    public int ServiceId { get; set; }
    public string DeviceType  { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNo { get; set; }
    public string MalfunctionDescription { get; set; }
    public DateTime AcceptanceDate { get; set; }
    public DateTime EstimatedCompletionDate { get; set; }
   
   
    [ForeignKey("StatusId")]
    public ServiceStatus ServiceStatus { get; set; }
    public int StatusId { get; set; }


    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }


}
