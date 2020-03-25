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
            //ActivateItemAsync(IoC.Get<PartsListViewModel>(), new CancellationToken()
            //{ DisplayName = "Part List" });

            ActivateItemAsync(IoC.Get<PartsListViewModel>(), new CancellationToken());
             DisplayName = "Part List";

        }
        public void AssembliesList() //AssembliesList
        {
            ActivateItemAsync(IoC.Get<AssembliesListViewModel>(), new CancellationToken());
            DisplayName = "Assembly List";
        }
        public void Demo()
        {
            ActivateItemAsync(IoC.Get<DemoViewModel>(), new CancellationToken());
            DisplayName = "Demo View";
        }

        public async Task DeactivateItemAndTryClose(IScreen item, bool close)
        {
            await DeactivateItemAsync(item, close, new CancellationToken());
            
        }


    }
}
