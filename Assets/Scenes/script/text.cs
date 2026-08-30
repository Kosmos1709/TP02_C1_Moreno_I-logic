using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;
    [SerializeField] private Button btnplay;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private Button btnsettings;
    [SerializeField] private GameObject SettingsMenu;

   
    private void Awake()
    {
        btnplay.onClick.AddListener(FunctionOnClick);
        btnsettings.onClick.AddListener(FunctionSettings);
    }
    void Start()
    {
        textComponent.text = "START";
    }
    private void OnDestroy()
    {
        btnplay.onClick.RemoveAllListeners();
        btnsettings.onClick.RemoveAllListeners();
    }

    private void FunctionSettings()
    {
        SettingsMenu.SetActive(!SettingsMenu.activeSelf);
        btnsettings.interactable = !btnsettings.interactable;
        btnplay.interactable = !btnplay.interactable; 


    }

    private void FunctionOnClick()
    {
        Debug.Log("Button clicked!");

        MainMenu.SetActive(!MainMenu.activeSelf);

    }
}
