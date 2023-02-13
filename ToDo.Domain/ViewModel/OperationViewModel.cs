using ToDo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.ViewModel
{
    public class OperationViewModel : BaseModel<int>
    {
        public OperationViewModel()
        {
            ETD = null;
            FlightDate = null;
            PatentDate = null;
        }
        public string AwbNo { get; set; }
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public int DepartureId { get; set; }
        public string DepartureName { get; set; }
        public int DestinationId { get; set; }
        public string DestinationName { get; set; }

        public DateTime? ETD { get; set; }
        public double? Pieces { get; set; }
        public double? Weight { get; set; }

        public string? OperationManager { get; set; }
        public string? FlightNo { get; set; }
        public DateTime? FlightDate { get; set; }
        public string? PatentNo { get; set; }
        public DateTime? PatentDate { get; set; }
        public string? Warehouse { get; set; }
        public double? CW { get; set; }
        public double? M3 { get; set; }
    }
}
