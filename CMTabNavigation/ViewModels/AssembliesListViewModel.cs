﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMTabNav.ViewModels
{
    public class AssembliesListViewModel : PropertyChangedBase, IHaveDisplayName
    {
        public string DisplayName { get; set; } = "Assembly";
    }
}
