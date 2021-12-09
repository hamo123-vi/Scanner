using System.Configuration;

/*
 * Config class intended for reading scanner settings from App.config file
 * Amil Valjevac, 09.12.2021.
*/

public static class Config
{

    public static int Resolution
    {
        get { return int.Parse(ConfigurationManager.AppSettings["resolution"]); }
    }
    public static int WidthPixel
    {
        get
        {
            return int.Parse(ConfigurationManager.AppSettings["width_pixel"]);
        }
    }
    public static int HeightPixel
    {
        get
        {
            return int.Parse(ConfigurationManager.AppSettings["height_pixel"]);
        }
    }
    public static int ColorMode
    {
        get
        {
            return int.Parse(ConfigurationManager.AppSettings["color_mode"]);
        }
    }
}