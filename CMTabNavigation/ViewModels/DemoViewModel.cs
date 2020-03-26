using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMTabNav.ViewModels
{
    public class DemoViewModel : PropertyChangedBase, IHaveDisplayName //Screen
    {
        public string DisplayName { get; set; } = "Demo";
    }
}
