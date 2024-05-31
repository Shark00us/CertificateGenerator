using CertificateGenerator.Strings;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CertificateGenerator.Utility_Side_Classes;

internal static class FontInstaller
{
    private static AppStrings _appStrings;

    public static void InjectDependency(AppStrings strings)
    {
        _appStrings = strings;
    }

    public static async void InstallFonts()
    {
        try
        {
            string tempPath = Path.GetTempPath();
            string scriptPath = Path.Combine(tempPath, AppStrings.FontInstallerScriptFileName);
            string[] fontPaths = {
                Path.Combine(tempPath, AppStrings.IranNastaliqFileName),
                Path.Combine(tempPath, AppStrings.RegularVazirFileName),
                Path.Combine(tempPath, AppStrings.BoldVazirFileName),
                Path.Combine(tempPath, AppStrings.LightVazirFileName)
            };
            ExtractResource(AppStrings.FontInstallerScriptResourcesPath, scriptPath);
            ExtractResource(AppStrings.IranNastaliqResourcesPath, fontPaths[0]);
            ExtractResource(AppStrings.RegularVazirResourcesPath, fontPaths[1]);
            ExtractResource(AppStrings.BoldVazirResourcesPath, fontPaths[2]);
            ExtractResource(AppStrings.LightVazirResourcesPath, fontPaths[3]);


            string arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            MySettings.SaveFontTry(false);
        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorRunningFontsScript, false);
            MySettings.SaveFontTry(true);
        }


    }

    private static void ExtractResource(string resourceName, string outputPath)
    {
        try
        {
            using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            if (stream == null)
            {
                throw new ArgumentException($"Resource {resourceName} not found.");
            }
            using FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            stream.CopyTo(fileStream);
        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorExtractingResources, false);
        }
    }

    public static bool CheckIfFontsAreInstalled()
    {
        try
        {
            using RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey(AppStrings.FontsRegistryPath);
            using RegistryKey localMachineKey = Registry.LocalMachine.OpenSubKey(AppStrings.FontsRegistryPath);
            foreach (var fontName in AppStrings.RegistryFontsNames)
            {
                string userValue = currentUserKey?.GetValue($"{fontName} (TrueType)") as string;
                string machineValue = localMachineKey?.GetValue($"{fontName} (TrueType)") as string;
                bool user = string.IsNullOrEmpty(userValue);
                bool machine = string.IsNullOrEmpty(machineValue);
                if (user && machine)
                {
                    return false;
                }
            }

        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorCheckingForFonts, false);
        }
        MySettings.SaveFontTry(false);
        return true;
    }
}