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
        CreditsMenu.SetActive(!CreditsMenu.activeSelf);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
