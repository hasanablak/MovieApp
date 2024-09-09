using System;
using System.Collections.Generic;

namespace LINQSamples.Data;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int Shipperid { get; set; }

    public decimal? Freight { get; set; }

    public string? ShipName { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipRegion { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }

    public virtual Customer Cust { get; set; } = null!;

    public virtual Shipper Shipper { get; set; } = null!;
}
