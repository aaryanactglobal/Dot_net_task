using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class RoomStay
{
    public int RoomStayId { get; set; }

    public int? RoomId { get; set; }

    public string? StayType { get; set; }

    public virtual Room? Room { get; set; }

    public virtual ICollection<RoomStayFacility> RoomStayFacilities { get; set; } = new List<RoomStayFacility>();
}
