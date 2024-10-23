using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public static class FontManager
{
    private static PrivateFontCollection privateFonts = new PrivateFontCollection();

    static FontManager()
    {
        string fontPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Fonts", "IRANSansXBlack.ttf");

        privateFonts.AddFontFile(fontPath);
    }

    public static Font GetCustomFont(float size)
    {
        return new Font(privateFonts.Families[0], size);
    }

    public static void ApplyCustomFont(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            control.Font = GetCustomFont(control.Font.Size);
            if (control.HasChildren)
            {
                ApplyCustomFont(control.Controls);
            }
        }
    }
}
