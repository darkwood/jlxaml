using System;

using Xamarin.Forms;

namespace jlxaml
{
    public partial class HuntDetailPage : ContentPage
    {
        HuntDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public HuntDetailPage()
        {
            InitializeComponent();

            var item = new Hunt
            {
                Location = "Location 1",
                Notes = "This is an item note."
            };

            viewModel = new HuntDetailViewModel(item);
            BindingContext = viewModel;
        }

        public HuntDetailPage(HuntDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
