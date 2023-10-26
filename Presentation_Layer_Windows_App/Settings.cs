using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer_Windows_App
{
    internal class clsSettings
    {
        public static Color PrimaryColor { get; set; } = Color.FromArgb(255, 209, 0);
        public static Color SecondaryColor { get; set; } = Color.FromArgb(30, 30, 30);
        public static Color MainForeEnableColor { get; set; } = Color.White;
        public static Color SecondaryForeEnableColor { get; set; } = Color.FromArgb(213, 213, 213);
        public static Color MainForeDisableColor { get; set; } =  Color.FromArgb(95, 95, 95);
    }
}
