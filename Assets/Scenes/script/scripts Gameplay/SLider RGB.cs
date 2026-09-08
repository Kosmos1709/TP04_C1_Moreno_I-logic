using UnityEngine;
using UnityEngine.UI;

public class SLiderRGB : MonoBehaviour
{
    [SerializeField] private Button Red;
    [SerializeField] private Button Blue;
    [SerializeField] private Button Green;
    [SerializeField] private Button OrignialColor;
    [SerializeField] private Renderer Player;



    void Start()
    {
        Red.onClick.AddListener(ChangeRed);
        Green.onClick.AddListener(ChangeGreen);
        Blue.onClick.AddListener(ChangeBlue);
        OrignialColor.onClick.AddListener(ChangeOriginalColor);
    }

    private void ChangeRed()
    {
           Player.material.color = Color.red;
    }
    private void ChangeGreen()
    {
        Player.material.color = Color.green;
    }
    private void ChangeBlue()
    {
        Player.material.color = Color.blue;
    }
    private void ChangeOriginalColor()
    {
            Player.material.color = Color.white;
    }
    void Update()
    {
        
    }
}
