using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rainbow : MonoBehaviour
{
    [SerializeField] private Text textForRainbow;
    [SerializeField] private float rainbowSpeed = 0.05;
    private float colorR;
    private float colorG;
    private float colorB;

    void Start()
    {
        rainbowSpeed = 0.05f;
        colorR = 1f;
        colorG = 1f;
        colorB = 0f;
        textForRainbow.color = new Color(colorR, colorG, colorB);
        StartCoroutine(RainbowCoroutine());
    }
    IEnumerator RainbowCoroutine()
    {
        if (textForRainbow.color.r == 1f)
        {
            if (textForRainbow.color.b == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g - 0.1f, textForRainbow.color.b);
                if (textForRainbow.color.g < 0f)
                    textForRainbow.color = new Color(textForRainbow.color.r, 0f, textForRainbow.color.b);
            }
            if (textForRainbow.color.g == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g, textForRainbow.color.b + 0.1f);
                if (textForRainbow.color.b > 1f)
                    textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g, 1f);
            }
        }
        if (textForRainbow.color.b == 1f)
        {
            if (textForRainbow.color.g == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r - 0.1f, textForRainbow.color.g, textForRainbow.color.b);
                if (textForRainbow.color.r < 0f)
                    textForRainbow.color = new Color(0f, textForRainbow.color.g, textForRainbow.color.b);
            }
            if (textForRainbow.color.r == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g + 0.1f, textForRainbow.color.b);
                if (textForRainbow.color.g > 1f)
                    textForRainbow.color = new Color(textForRainbow.color.r, 1f, textForRainbow.color.b);
                if (textForRainbow.color.g < 0f)
                    textForRainbow.color = new Color(textForRainbow.color.r, 0f, textForRainbow.color.b);
            }
        }
        if (textForRainbow.color.g == 1f)
        {
            if (textForRainbow.color.r == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g, textForRainbow.color.b - 0.1f);
                if (textForRainbow.color.b < 0f)
                    textForRainbow.color = new Color(textForRainbow.color.r, textForRainbow.color.g, 0f);
            }
            if (textForRainbow.color.b == 0f)
            { 
                textForRainbow.color = new Color(textForRainbow.color.r + 0.1f, textForRainbow.color.g, textForRainbow.color.b);
                if (textForRainbow.color.r > 1f)
                    textForRainbow.color = new Color(1f, textForRainbow.color.g, textForRainbow.color.b);
            }
        }
        yield return new WaitForSeconds(rainbowSpeed);
        StartCoroutine(RainbowCoroutine());
    }
}
