using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComeBackMenu : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private Button BackBtn;
    [SerializeField] private GameObject PauseMenu;
    
    public float Timescale;

    private void Awake()
    {
        BackBtn.onClick.AddListener(BackToMenu);
    }
    private void OnDestroy()
    {
        BackBtn.onClick.RemoveAllListeners();
    }
    void Start()
    {
    }

    private void BackToMenu()
    {
        Timescale = 0f;
        Debug.Log("Botón pulsado");
        SceneManager.LoadScene("Main Menu");

    }
    void Update()
    {
        Time.timeScale = Timescale;
        if (Timescale == 1) 
        {
            PauseMenu.SetActive(false);
        }


        
        

        
    }
}
