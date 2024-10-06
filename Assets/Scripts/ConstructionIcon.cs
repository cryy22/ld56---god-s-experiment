using UnityEngine;
using UnityEngine.UI;

namespace GodsExperiment
{
    public class ConstructionIcon : MonoBehaviour
    {
        [SerializeField] private Image ResourceIcon;
        public void SetIcon(Sprite icon) { ResourceIcon.sprite = icon; }
    }
}
