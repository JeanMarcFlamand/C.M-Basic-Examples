using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CMTabNav.ViewModels
{
    class PartsListViewModel : PropertyChangedBase, IHaveDisplayName //Screen
    {
        private string _displayname ="Part List" ;

        public string DisplayName
        {
            get { return _displayname ; }
            set { _displayname = value; }
        }


    }

    
}
