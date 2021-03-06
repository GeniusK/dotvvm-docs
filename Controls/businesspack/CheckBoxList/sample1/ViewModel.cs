using System.Collections.Generic;
using DotVVM.Framework.ViewModel;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.CheckBoxList.sample1
{
    public class ViewModel : DotvvmViewModelBase
    {
        public List<string> Countries { get; set; } = new List<string> {
            "Czech Republic", "Slovakia", "United States"
        };

        public List<string> SelectedCountries { get; set; } = new List<string>();
    }
}