using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class RoomStayFacility
{
    public int RoomStayFacilityId { get; set; }

    public int? RoomStayId { get; set; }

    public string? FacilityCode { get; set; }

    public string? FacilityGroupCode { get; set; }

    public int? Number { get; set; }

    public virtual RoomStay? RoomStay { get; set; }
}
