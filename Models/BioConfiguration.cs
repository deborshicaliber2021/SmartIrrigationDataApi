using System.ComponentModel.DataAnnotations.Schema;

namespace SmartIrrigationDataApi.Models
{
    public class BioConfiguration
    {
        public string PlantID { get; set; }
        
        public int OptimalWaterVolumn { get; set; }
        
    }
            
    
}