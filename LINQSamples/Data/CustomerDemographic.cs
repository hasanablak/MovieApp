using System;
using System.Collections.Generic;

namespace LINQSamples.Data;

public partial class CustomerDemographic
{
    public int CustomerTypeId { get; set; }

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Custs { get; set; } = new List<Customer>();
}
