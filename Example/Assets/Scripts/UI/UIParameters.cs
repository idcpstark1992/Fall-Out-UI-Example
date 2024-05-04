using Demo.Config;
using UnityEngine;
namespace Demo.Commons
{
    public static class UIParameters
    {
        public static Color SelectedColor       { get; private set; }
        public static Color IdleColor           { get; private set; }
        public static Color SelectedFontColor   { get; private set; }
        public static Color IdleFontColor       { get; private set; }
        public static float ScaleMotionSpeed    { get; private set; }

        public static void SetConfigOnMemory(UIConfigParams _injectionFile)
        {
            SelectedColor       = _injectionFile.GetData().SELECTEDCOLOR;
            IdleColor           = _injectionFile.GetData().IDLECOLOR;
            SelectedFontColor   = _injectionFile.GetData().SELECTED_FONT_COLOR;
            IdleFontColor       = _injectionFile.GetData().IDLE_FONT_COLOR;
            ScaleMotionSpeed    = _injectionFile.GetData().SCALE_SPEED;
        }
    }

}