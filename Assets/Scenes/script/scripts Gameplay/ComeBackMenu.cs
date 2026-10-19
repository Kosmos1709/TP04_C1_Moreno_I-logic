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
        // Bug: este Update escribe Time.timeScale en cada frame con el valor de Timescale, que en Gameplay.unity está serializado en 0 y nunca se pone en 1 (BackToMenu solo lo vuelve a poner en 0).
        // Al mismo tiempo, los dos MovimentPlayers de la escena escriben Time.timeScale = 1 desde su propio Update, así que el tiempo del juego depende de cuál de los tres corra último en el frame. Eso no está definido.
        // Sacá esta línea: el timeScale lo tiene que manejar un solo script, el de pausa.
        Time.timeScale = Timescale;
        if (Timescale == 1) 
        {
            PauseMenu.SetActive(false);
        }


        
        

        
    }
}
