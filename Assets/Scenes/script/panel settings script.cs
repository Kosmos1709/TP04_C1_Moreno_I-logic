using UnityEngine;
using UnityEngine.UI;

public class panelsettingsscript : MonoBehaviour
{
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private Button BackBtn;
        [SerializeField] private Button SettingsBtn;
        [SerializeField] private Button btnplay;


    private void Awake()
    {
       
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        if (SettingsMenu.activeSelf) {
            SettingsBtn.interactable = false;
            btnplay.interactable = false;
             }
        if (!SettingsMenu.activeSelf) {
            btnplay.interactable = true;
            SettingsBtn.interactable = true;
        }
    }
}
