﻿using System;

namespace jlxaml
{
    public class HuntDetailViewModel : BaseViewModel
    {
        public Hunt Item { get; set; }
        public HuntDetailViewModel(Hunt item = null)
        {
            Title = item?.Location;
            Item = item;
        }
    }
}
