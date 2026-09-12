using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class Timerround : MonoBehaviour
{
    [SerializeField] private TMP_Text TimerText;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject VictoryMenu;

    public float roundTime = 20f;
    private int Seconds;
    private int cent;

    
    void Start()
    {
    }


     private void Update()
    {
        roundTime -= Time.deltaTime;
       
        ////////////
        if (!PauseMenu.activeSelf || !VictoryMenu.activeSelf)
        {
            
            Seconds = Mathf.FloorToInt(roundTime % 60);
            cent = Mathf.FloorToInt((roundTime * 100) % 100);
            TimerText.text = string.Format("{0:00}:{1:00}", Seconds, cent);
        }
        
        if (roundTime <= 0)
        {
            roundTime = 0;
            TimerText.text = "00:00";
        }   


    }

   
    public void ResetTimer()
    {
        roundTime = 20f;
    }

}
