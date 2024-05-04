using UnityEngine;

namespace Demo.Config
{
    [CreateAssetMenu(fileName = "Data", menuName = "Config/UIConfigFile", order = 1)]
    public class UIConfigParams : ScriptableObject
    {
        [SerializeField] private Color _selectedColor;
        [SerializeField] private Color _idleColor;
        [SerializeField] private Color _selectedFontColor;
        [SerializeField] private Color _idleFontColor;
        [SerializeField] private float _scaleSpeed;

        public (Color SELECTEDCOLOR, Color IDLECOLOR ,Color SELECTED_FONT_COLOR , Color IDLE_FONT_COLOR, float SCALE_SPEED) GetData()
        {
            return (_selectedColor, _idleColor, _selectedFontColor, _idleFontColor, _scaleSpeed);
        }
    }
}
