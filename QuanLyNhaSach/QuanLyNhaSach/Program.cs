using QLNhanVIen;
using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    internal static class Program
    {
        public static Home homeForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeForm = new Home();
            Application.Run(new DangNhap1());
        }
    }
}
