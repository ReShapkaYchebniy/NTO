﻿using System;
using System.Collections.Generic;

namespace Cultura.data;

public partial class Space
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; } = new List<Application>();

    public virtual ICollection<Circle> Circles { get; } = new List<Circle>();

    public virtual ICollection<Reservation> Reservations { get; } = new List<Reservation>();
}
