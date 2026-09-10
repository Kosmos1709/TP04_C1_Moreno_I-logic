using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timerround : MonoBehaviour
{
    [SerializeField] private TMP_Text TimerText;
    [SerializeField] private GameObject PauseMenu;
    public float roundTime ;
    private int Seconds;
    private int cent;

    
    void Start()
    {
    }


     private void Update()
    {
        roundTime -= Time.deltaTime;
       
        ////////////
        if (!PauseMenu.activeSelf)
        {
            
            Seconds = Mathf.FloorToInt(roundTime % 60);
            cent = Mathf.FloorToInt((roundTime * 100) % 100);
            TimerText.text = string.Format("{0:00}:{1:00}", Seconds, cent);
        }
        
    }
   
}
