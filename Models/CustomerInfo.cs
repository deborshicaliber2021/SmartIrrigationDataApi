using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartIrrigationDataApi.Models
{
    [Table("TBL_Customers")]
    public class CustomerInfo
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("CustomerID")]
        public string CustomerID { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("CustomerName")]
        public string CustomerName { get; set; }
        [Column("ContactNo")]
        public string ContactNo { get; set; }
    }
            
    
}