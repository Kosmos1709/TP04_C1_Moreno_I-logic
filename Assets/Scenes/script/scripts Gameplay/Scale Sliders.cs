using UnityEngine;
using UnityEngine.UI;

public class ScaleSliders : MonoBehaviour
{
    [SerializeField] private Slider scalePlayer1;
    [SerializeField] private Slider scalePlayer2;
    [SerializeField] private MovimentPlayers Player1;
    [SerializeField] private MovimentPlayers Player2;

    void Start()
    {
        scalePlayer1.onValueChanged.AddListener(SlideScale1);
        scalePlayer2.onValueChanged.AddListener(SlideScale2);
    }

    private void SlideScale1(float value)
    {
        Player1.ScalePlayer1 = value;
        Player1.transform.localScale = new Vector3(1f, value, 1f);
    }
    private void SlideScale2(float value)
    {
        Player2.ScalePlayer2 = value;
        Player2.transform.localScale = new Vector3(1f, value, 1f);
    }
    void Update()
    {
        
    }
}
