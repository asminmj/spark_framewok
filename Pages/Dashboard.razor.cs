using Microsoft.AspNetCore.Components;
using MyAppName.Application.Models;
using MyAppName.Pages.Shared;

namespace MyAppName.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout.User;
}
