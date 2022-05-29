using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Blazor_Authentication_Authorization.BlazorApp.Shared;

public partial class LoginDisplay : ComponentBase
{
    [Inject]
    private IDialogService DialogService { get; set; }


    private async Task OnLogRegisterButton_Click()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true };
        //_dialogService.Show<DialogUsageExample_Dialog>("Simple Dialog", options);
    }
}
