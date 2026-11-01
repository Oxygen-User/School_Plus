using UnityEngine;
using UnityEngine.UI;

public class AlphaInverter : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Slider targetSlider;
    [SerializeField] private Image targetImage;
    [SerializeField] private Image targetImage1;
    [SerializeField] private Image targetImage2;
    [SerializeField] private Image targetImage3;
    [SerializeField] private Image targetImage4;


    void Start()
    {
        float value = targetSlider.value; 
        
        
        // Subtract the slider value from 1
        float invertedAlpha = 1f - value;

        // Get the current color, update only the alpha channel, and reassign it
        Color newColor = targetImage.color;
        newColor.a = invertedAlpha;
        targetImage.color = newColor;
        targetImage1.color = newColor;
        targetImage2.color = newColor;
        targetImage3.color = newColor;
        targetImage4.color = newColor;

        Debug.Log("ÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYORÇALIŞIYOR");

        
    }

    void Update()
    {
        
    }



    public void OnSliderValueChanged()
    {
        float value = targetSlider.value; 
        if (targetImage != null)
        {
            // Subtract the slider value from 1
            float invertedAlpha = 1f - value;

            // Get the current color, update only the alpha channel, and reassign it
            Color newColor = targetImage.color;
            newColor.a = invertedAlpha;
            targetImage.color = newColor;
            targetImage1.color = newColor;
            targetImage2.color = newColor;
            targetImage3.color = newColor;
            targetImage4.color = newColor;

        }
    }
}