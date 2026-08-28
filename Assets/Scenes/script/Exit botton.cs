using System;
using UnityEngine;
using UnityEngine.UI;

public class Exitbotton : MonoBehaviour
{
    [SerializeField] private Button Exitbtn;


    private void Awake()
    {
        Exitbtn.onClick.AddListener(FunctionExit);
    }
    private void OnDestroy()
    {
        Exitbtn.onClick.RemoveAllListeners();
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
        
    }
}
