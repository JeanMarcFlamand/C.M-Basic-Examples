using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMTabNav.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel()
        {
            
        }

        public void PartsList()
        {
            //var partsListViewModel = IoC.Get<PartsListViewModel>();
            //partsListViewModel.DisplayName = "Part List";
            ActivateItemAsync(IoC.Get<PartsListViewModel>(), new CancellationToken());
        }
        public void AssembliesList() //AssembliesList
        {
            ActivateItemAsync(IoC.Get<AssembliesListViewModel>(), new CancellationToken());
            
        }
        public void Demo()
        {
            ActivateItemAsync(IoC.Get<DemoViewModel>(), new CancellationToken());
            
        }

        public async Task DeactivateItemAndTryClose(PropertyChangedBase item, bool close)
        {
            await DeactivateItemAsync(item, close, new CancellationToken());
            
        }


    }
}
