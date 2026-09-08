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
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
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
