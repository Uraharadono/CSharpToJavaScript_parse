using System.ComponentModel;

namespace Utility.Enums
{
    public enum EGenerateOptions
    {
        [Description("Javascript")]
        Javascript = 0,
        [Description("Ecma6 Javascript")]
        Ecma6 = 1,
        [Description("Ecma6 with Knockout")]
        KnockoutEcma6 = 2
    }
}
