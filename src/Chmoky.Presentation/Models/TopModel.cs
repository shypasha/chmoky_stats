﻿using System;
using System.Collections.Generic;

namespace Chmoky.Presentation.Models
{
    public class TopModel
    {
        public Nullable<int> participants { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<int> textLength { get; set; }
        public Nullable<int> min { get; set; }
        public Nullable<int> max { get; set; }
        public Nullable<int> avg { get; set; }
        public Nullable<int> total { get; set; }
        public IEnumerable<TopRecordModel> rows { get; set; }
    }
}