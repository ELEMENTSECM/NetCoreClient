using Microsoft.Extensions.Configuration;
using NCoreClientCore.NetStandard;
using NCoreClientCore.WinForms.Framework;
using System;
using System.Windows.Forms;

namespace NCoreClientCore.Winforms.NetCore
{
    static class Program
    {
        static IConfigurationRoot Configuration { get;set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            //https://benfoster.io/blog/net-core-configuration-legacy-projects
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.app01v66.elements-ecm.no.json", optional: true)
                .AddEnvironmentVariables(prefix: "PREFIX_")
                .AddCommandLine(args)
                .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static NCoreOptions GetNCoreOptions()
        {
            return Configuration.GetSection("NCore").Get<NCoreOptions>();
        }

    }
}
