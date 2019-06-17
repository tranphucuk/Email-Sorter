using DevExpress.XtraEditors;
using Email_Sorter_Tool.HomeModule.EventArgs;
using Email_Sorter_Tool.Settings;
using Email_Sorter_Tool.Static;
using OmegaLib.Networks;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thanhps42.HttpClient;

namespace Email_Sorter_Tool.HomeModule
{
    public class TaskManager
    {
        public Http Http { get; set; }
        public BvSshClient SshClient { get; set; }

        public void ChangeIp(ConcurrentBag<SshDetail> originalBag)
        {
            HomeStatic.Instance.SshAutoControlIfNostExist();
            int port;
            SshDetail currentSsh = null;

            while (true)
            {
                port = NetworkHelper.GetAvailablePort();
                if (originalBag.TryTake(out currentSsh))
                {
                    var loginSuccess = SshClient.Login(currentSsh.Host, currentSsh.Username, currentSsh.Password, port, 5);
                    if (loginSuccess)
                    {
                        break;
                    }
                }
            }
            Http.ProxyType = thanhps42.HttpClient.Enums.ProxyType.Socks5;
            Http.ProxyPort = port;
            Http.SocksVersion = 5;
            Http.SocksHostname = "127.0.0.1";
            Http.SocksPort = port;
        }

        public TaskManager()
        {
            SshClient = new BvSshClient(Application.StartupPath + "\\BvSsh\\BvSsh.exe", Application.StartupPath + "\\BvSsh\\default.bscp", new object());
            Http = new Http();
        }
    }
}
