﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Myfashion.Domain
{
    public interface IDraftsRepository
    {
        void AddDrafts(Drafts d);
        int DeleteDrafts(Drafts d);
        void UpdateDrafts(Drafts d);

    }
}