using System;
using UnityEngine;
using UnityEngine.UI;

public class Exitbotton : MonoBehaviour
{
    [SerializeField] private Button Exitbtn;
    [SerializeField] private Button BackToSettings;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private Button btnplay;


    private void Awake()
    {
        Exitbtn.onClick.AddListener(FunctionExit);
        BackToSettings.onClick.AddListener(FunctionBackToSettings);
    }
    private void OnDestroy()
    {
        Exitbtn.onClick.RemoveAllListeners();
        BackToSettings.onClick.RemoveAllListeners();
    }
    private void FunctionBackToSettings()
    {
        SettingsPanel.SetActive(false);
    }
    private void FunctionExit()
    {
        Debug.Log("Boton de Salir presionado");
        // Warning: Application.Quit() sin el bloque #if UNITY_EDITOR. En el build funciona, pero en el editor el botón no hace nada y parece roto. Es la misma observación del TP03.
        // Agregá abajo: #if UNITY_EDITOR UnityEditor.EditorApplication.isPlaying = false; #endif
        Application.Quit();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SettingsPanel.activeSelf)
        {
            btnplay.interactable = false;
        }
        if (!SettingsPanel.activeSelf)
        {
            btnplay.interactable = true;
        }
    }
   }
