using ToDo.Domain.Model;

namespace ToDo.Domain.ViewModel
{
    public class BookingViewModel : BaseModel<int>
    {
        public string BookingNo { get; set; }

        public int ShipperId { get; set; }
        public string ShipperName { get; set; }

        public int ConalgneeId { get; set; }
        public string ConalgneeName { get; set; }

        public int? DepartureId { get; set; }
        public string DepartureName { get; set; }

        public int? DestinationId { get; set; }
        public string DestinationName { get; set; }

        public int? IncoTermId { get; set; }
        public string IncoTermName { get; set; }

        public int? MarketingAreaId { get; set; }
        public string MarketingAreaName { get; set; }

        public string? Delivery { get; set; }
        public string? Pickup { get; set; }
        public int? AirlineId { get; set; }
        public string AirlingName { get; set; }

        public DateTime? ReadyDate { get; set; }
        public int? Pieces { get; set; }
        public int? CW { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }

        public int? AgentId { get; set; }
        public string AgentName { get; set; }

        public int? ColoaderId { get; set; }
        public string ColoaderName { get; set; }

        public string? Content { get; set; }
        public int? StateId { get; set; }
        public string StateName { get; set; }

        public double? GWeight { get; set; }
        public double? M3 { get; set; }
        public int? MainCompanyId { get; set; }
        public string MainCompanyName { get; set; }

        public DateTime? WEntryDate { get; set; }
        public DateTime? WEntryTime { get; set; }
        public int? FreightId { get; set; }
        public string? FreightName { get; set; }

        public int? BusinessModelId { get; set; }
        public string? BusinessModelName { get; set; }

        public bool? FlightDeparted { get; set; }
        public string FlightDepartedName { get; set; }

        public bool? Ordino { get; set; }
        public bool? RellefCargo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

       
    }
}