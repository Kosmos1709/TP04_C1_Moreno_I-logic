using UnityEngine;
using UnityEngine.UI;

public class credits : MonoBehaviour
{

    [SerializeField] private Button btncredits;
    [SerializeField] private GameObject CreditsMenu;

    private void Awake()
    {
     
        btncredits.onClick.AddListener(FunctionCredits);
    }

    private void OnDestroy()
    {
        btncredits.onClick.RemoveAllListeners();

    }


    private void FunctionCredits()
    {
        Debug.Log("Boton de Creditos presionado");
        if (CreditsMenu.activeSelf ) {
            CreditsMenu.SetActive(false);
        }
        else if (CreditsMenu.activeSelf == false) {
            CreditsMenu.SetActive(true);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
