﻿namespace Oqtane.Infrastructure
{
    public interface IInstallationManager
    {
        void InstallPackages(string Folders, bool Restart);
        void RestartApplication();
    }
}
