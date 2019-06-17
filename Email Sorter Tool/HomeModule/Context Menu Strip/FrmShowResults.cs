using Email_Sorter_Tool.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sorter_Tool.HomeModule.Context_Menu_Strip
{
    public partial class FrmShowResults : Form
    {
        public FrmShowResults()
        {
            InitializeComponent();
        }

        public FrmShowResults(string EmailTypeName)
        {
            InitializeComponent();
            lblEmailType.Text = EmailTypeName.Replace(".txt","") + " Email";
            var lines = File.ReadAllLines(HomeStatic.saveFolderPath + EmailTypeName).ToList();
            lblTotalEmails.Text = "Total: " + lines.Count.ToString();
            lines.ForEach(x => mmEmailResults.Text += x + Environment.NewLine);
            mmEmailResults.SelectionStart = lines.Count;
            mmEmailResults.ScrollToCaret();
        }
    }
}
