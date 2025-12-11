using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTH3
{
    internal static class Program
    {

        public static string configFile = "config.ini";
        public static DataHelper Db;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (KiemTraKetNoi())
                Application.Run(new frmdangnhap());
            else
                Application.Run(new frmcauhinh());
        }

        public static bool KiemTraKetNoi()
        {
            string quyen, SN, DN, UC, PW;

            if (!File.Exists(configFile))
            {
                File.Create(configFile).Close();
                return false;
            }

            DataHelper.DocTep(configFile, out quyen, out SN, out DN, out UC, out PW);

            if (string.IsNullOrEmpty(SN) || string.IsNullOrEmpty(DN))
                return false;

            try
            {
                DataHelper dt;
                if (quyen == "WD")
                    dt = new DataHelper(SN, DN);
                else
                    dt = new DataHelper(SN, DN, UC, PW);

                dt.MoKetNoi();
                Db = dt;
                dt.DongKetNoi();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

