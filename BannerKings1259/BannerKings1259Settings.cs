using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Base.Global;

namespace BannnerKings1259.Settings
{
    public class BannerKings1259Settings : AttributeGlobalSettings<BannerKings1259Settings>
    {
        public override string Id => "BannerKinsg1259Settings";
        public override string DisplayName => "Banner Kings 1259";
        public override string FolderName => "BannerKings1259";
        public override string FormatType => "json";

        [SettingPropertyBool(
            "Use English Titles",
            HintText = "If enabled, all titles will use English names instead of native-language ones.",
            IsToggle = true,
            RequireRestart = true)]
        public bool UseEnglishTitles { get; set; }
    }
}
