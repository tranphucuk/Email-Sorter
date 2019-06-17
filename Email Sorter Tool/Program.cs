using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using thanhps42.Common;
using FoxLearn.License;

namespace Email_Sorter_Tool
{
    static class Program
    {
        public static string licensePath => Application.StartupPath + "\\license.eth";
        public static string passwordToEncryptKey = "FJ:$%)Wa$^JDU(3#$<%^?<:P)%Kh6L886GKG$$43*7J>^($h#+==31ScDtiAPLhS%";
        private static string _computerId;
        public static string ComputerId
        {
            get
            {
                return _computerId;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _computerId = ComputerInfo.GetComputerId();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}
