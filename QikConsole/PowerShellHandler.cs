using System.Management.Automation;
using System.Text;
using System;

// https://github.com/BlueHippoGithub/How-to-use-PowerShell-with-C-Sharp
// https://www.youtube.com/channel/UC9qObYsgg5frlIwqdBjHlYw

namespace PowershellShowcase;

public static class PowerShellHandler
{
    private static readonly PowerShell powerShell = PowerShell.Create();

    public static string Command(string script)
    {
        string errorMsg = string.Empty;

        powerShell.AddScript(script);

        //Make sure return values are outputted to the stream captured by C#
        powerShell.AddCommand("Out-String");

        PSDataCollection<PSObject> outputCollection = new();
        powerShell.Streams.Error.DataAdded += (object sender, DataAddedEventArgs e) =>
        {
            errorMsg = ((PSDataCollection<ErrorRecord>)sender)[e.Index].ToString();
        };


        IAsyncResult result = powerShell.BeginInvoke<PSObject, PSObject>(null, outputCollection);

        //Wait for powershell command/script to finish executing
        powerShell.EndInvoke(result);

        StringBuilder sb = new();

        foreach (var outputItem in outputCollection)
        {
            sb.AppendLine(outputItem.BaseObject.ToString());
        }
        
        //Clears the commands we added to the powershell runspace so it's empty the next time we use it
        powerShell.Commands.Clear();

        //If an error is encountered, return it
        if (!string.IsNullOrEmpty(errorMsg))
            return errorMsg;

        return sb.ToString().Trim();
    }
}
