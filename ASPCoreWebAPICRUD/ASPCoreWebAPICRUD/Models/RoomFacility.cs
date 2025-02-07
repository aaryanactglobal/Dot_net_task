using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class RoomFacility
{
    public int RoomFacilityId { get; set; }

    public int? RoomId { get; set; }

    public string? FacilityCode { get; set; }

    public string? FacilityGroupCode { get; set; }

    public int? Number { get; set; }

    public string? Voucher { get; set; }

    public virtual Room? Room { get; set; }
}
