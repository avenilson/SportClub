﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SportClub.Domain.Common
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        int PageSize { get; set; } //mitu kirjet uhele lk laheb 
        int TotalPages { get; } //ise arvutab palju lk vaja
        bool HasNextPage { get; }
        bool HasPreviousPage { get; }
    }
}
