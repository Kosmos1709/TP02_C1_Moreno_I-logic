using UnityEngine;
using UnityEngine.UI;

public class sliders : MonoBehaviour
{
    [SerializeField] private Slider SliderPlayer1;
    [SerializeField] private Slider SliderPlayer2;
    [SerializeField] private Movement PlayerOne;
    [SerializeField] private Movement PlayerTwo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SliderPlayer1.onValueChanged.AddListener(SlidePlay1);
        SliderPlayer2.onValueChanged.AddListener(SlidePlay2);
    }

    // Update is called once per frame
    private void SlidePlay1(float value)
    {
        PlayerOne.speed = value;
    }

    private void SlidePlay2(float value)
    {
        PlayerTwo.speed = value;
    }

    void Update()
    {
       
    }
}
