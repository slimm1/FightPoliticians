using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    internal class FontManager
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        
        public FontManager() {
            pfc.AddFontFile(Constant.FONT_PATH);
        }
        public Font TitleFont() {
            return new Font(pfc.Families[0], 25);
        }
        public Font MediumFont()
        {
            return new Font(pfc.Families[0], 12);
        }
        public Font SmallFont()
        {
            return new Font(pfc.Families[0], 9);
        }
    }
}
