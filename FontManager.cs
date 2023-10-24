using System;
using System.Drawing;
using System.Drawing.Text;

public static class FontManager
{
    private static Font customFont;
    private static Font anotherCustomFont;
    private static Font yetAnotherCustomFont;

    public static Font CustomFont
    {
        get
        {
            if (customFont == null)
            {
                LoadCustomFonts();
            }
            return customFont;
        }
    }

    public static Font AnotherCustomFont
    {
        get
        {
            if (anotherCustomFont == null)
            {
                LoadCustomFonts();
            }
            return anotherCustomFont;
        }
    }

    public static Font YetAnotherCustomFont
    {
        get
        {
            if (yetAnotherCustomFont == null)
            {
                LoadCustomFonts();
            }
            return yetAnotherCustomFont;
        }
    }

    private static void LoadCustomFonts()
    {
        var customFontCollection = new PrivateFontCollection();
        customFontCollection.AddFontFile("futur.ttf"); // Replace with the actual font file path

        var anotherFontCollection = new PrivateFontCollection();
        anotherFontCollection.AddFontFile("Futura Light font.ttf"); // Replace with the actual font file path

        var yetAnotherFontCollection = new PrivateFontCollection();
        yetAnotherFontCollection.AddFontFile("Proxima Nova Font.otf"); // Replace with the actual font file path

        customFont = new Font(customFontCollection.Families[0], 12f);
        anotherCustomFont = new Font(anotherFontCollection.Families[0], 12f);
        yetAnotherCustomFont = new Font(yetAnotherFontCollection.Families[0], 12f);
    }
}
