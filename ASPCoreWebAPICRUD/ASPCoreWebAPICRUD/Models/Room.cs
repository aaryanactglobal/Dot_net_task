using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int? HotelId { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomType { get; set; }

    public string? CharacteristicCode { get; set; }

    public int? MinPax { get; set; }

    public int? MaxPax { get; set; }

    public int? MaxAdults { get; set; }

    public int? MaxChildren { get; set; }

    public int? MinAdults { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual ICollection<RoomFacility> RoomFacilities { get; set; } = new List<RoomFacility>();

    public virtual ICollection<RoomStay> RoomStays { get; set; } = new List<RoomStay>();
}
