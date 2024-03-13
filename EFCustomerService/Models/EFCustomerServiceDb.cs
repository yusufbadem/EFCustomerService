using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCustomerService.Models;
public class EFCustomerServiceDb:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0ESM5CG;Initial Catalog=EFCustomerServiceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Customer> Customers { get; set;}
    public DbSet<ServiceRecord> ServiceRecords { get; set; }
    public DbSet<SparePart> SpareParts { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<ServiceStatus> ServiceStatuses { get; set; }
    public DbSet<Invoice> Invoices { get; set; }


}
