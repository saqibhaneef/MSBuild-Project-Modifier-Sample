using Microsoft.Build.Locator;
using Microsoft.Extensions.DependencyInjection;
using MSBuildProjectModifier.Extensions;
using MSBuildProjectModifierSample;

class Program
{
    static void Main(string[] args)
    {
        MSBuildLocator.RegisterDefaults();
       
        var services = new ServiceCollection();
        services.BuildServiceProvider();
        services.AddMsBuildManager();

        services.AddTransient<ConsoleMenu>();

        
        var serviceProvider = services.BuildServiceProvider();
        

        var consoleMenu = serviceProvider.GetService<ConsoleMenu>();

        consoleMenu.ProjectModifier();

    }

}