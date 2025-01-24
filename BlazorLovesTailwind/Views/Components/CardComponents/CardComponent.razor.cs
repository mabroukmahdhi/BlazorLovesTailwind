using Microsoft.AspNetCore.Components;
using static BlazorLovesTailwind.Components.Pages.Home;

namespace BlazorLovesTailwind.Views.Components.CardComponents
{
    public partial class CardComponent : ComponentBase
    {

        [Parameter]
        public Mvp Mvp { get; set; }
    }
}