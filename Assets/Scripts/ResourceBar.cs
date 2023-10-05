using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DecisionMaking.UAI
{
    public class ResourceBar : MonoBehaviour
    {
        [SerializeField] private Image fillDisplay;
        [SerializeField] private Color color;

        private void Start()
        {
            fillDisplay.color = new Color(color.r, color.g, color.b);
        }

        public void UpdateFill(float amount)
        {
            fillDisplay.rectTransform.localScale = new Vector3(amount, 1, 1);
        }
    }
}