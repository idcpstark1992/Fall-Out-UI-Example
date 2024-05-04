using UnityEngine;
using Demo.Commons;

namespace Demo.Config
{
    public class UIConfigurationInjection : MonoBehaviour
    {
        [SerializeField] private UIConfigParams _configFile;

        private void Awake()
        {
            UIParameters.SetConfigOnMemory(_configFile);
        }
    }
}
