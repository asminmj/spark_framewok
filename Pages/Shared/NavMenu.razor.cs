using Microsoft.AspNetCore.Components;
using MyAppName.Application.Models;

namespace MyAppName.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout?.User;
}
