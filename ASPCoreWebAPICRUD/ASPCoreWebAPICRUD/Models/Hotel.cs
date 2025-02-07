using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? CountryCode { get; set; }

    public string? StateCode { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Address { get; set; }

    public string? Coordinates { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryGroupCode { get; set; }

    public string? ChainCode { get; set; }

    public string? AccommodationTypeCode { get; set; }

    public string? Email { get; set; }

    public string? License { get; set; }

    public string? Website { get; set; }

    public int? Ranking { get; set; }

    public byte[] LastUpdate { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
