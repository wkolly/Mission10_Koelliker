﻿using System;
using System.Collections.Generic;

namespace Mission10_Koelliker_Backend.Data;

public partial class ZtblWeek
{
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
