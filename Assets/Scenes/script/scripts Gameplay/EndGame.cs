using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject PanelWin;
    [SerializeField] private GameObject PanelLose;
    [SerializeField] private GameObject PanelVictory;
    [SerializeField] private Score score;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PanelWin.GetComponent<RectTransform>().anchoredPosition =
            new Vector2();
    }

    // Update is called once per frame
    public void Player1Win ()
    {
        PanelWin.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(-472, 0);
        PanelLose.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(472, 0);

        if (score.EndOFGame== true)
        {
            PanelVictory.SetActive(true);
        }
    }
    public void Player2Win()
    {
        PanelWin.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(472, 0);
        PanelLose.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(-472, 0);

        if (score.EndOFGame == true)
        {
            PanelVictory.SetActive(true);

        }
    }
    void Update()
    {
        
    }
}
