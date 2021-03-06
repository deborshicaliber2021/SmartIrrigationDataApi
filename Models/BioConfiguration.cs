using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartIrrigationDataApi.Models
{
    [Table("TBL_BioConfigurations_App")]
    public class BioConfiguration
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string ID { get; set; }
        public string CustomerID { get; set; }
        public string DeviceID { get; set; }
        public string PlantID { get; set; }
        public int WateringFrequencyInDays { get; set; }
        public DateTime CreatedDate{get;set;}
        public decimal OptimalWaterVolumnInLitres { get; set; }
        
    }
            
    
}