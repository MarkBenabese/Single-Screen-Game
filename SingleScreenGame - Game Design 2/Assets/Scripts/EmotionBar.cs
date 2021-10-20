using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxEmotion(int emotion)
    {
        slider.maxValue = emotion;
        slider.value = emotion;

        fill.color = gradient.Evaluate(0.1f);
    }

    public void SetEmotion(int emotion)
    {
        slider.value = emotion;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
