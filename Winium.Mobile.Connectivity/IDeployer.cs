namespace Winium.Mobile.Connectivity
{
    #region

    using System.Collections.Generic;

    #endregion

    public interface IDeployer
    {
        #region Public Properties

        string DeviceName { get; }

        bool IsEmulator { get; }

        #endregion

        #region Public Methods and Operators

        void Install(string appPath, List<string> dependencies);

        void UsePreInstalledApplication(string appPath);

        void Launch();

        void ReceiveFile(string isoStoreRoot, string sourceDeviceFilePath, string targetDesktopFilePath);

        void SendFiles(Dictionary<string, string> files);

        void Terminate();

        void Uninstall();

        void GetEndPoints(int servicePort, out string sourceIp, out string destinationIp, out int destinationPort);

        #endregion
    }
}
