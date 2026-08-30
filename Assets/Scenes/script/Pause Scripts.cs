using UnityEngine;
using UnityEngine.UI;

public class PauseScripts : MonoBehaviour
{
    [Header("Boton de Pausa")]
    [SerializeField] private KeyCode EscBtn = KeyCode.Escape;
    [Header("Pause Menu")]
    [SerializeField] private GameObject PauseMenu; //objeto canvas
    [SerializeField] private Button ContinueBtn;
    [SerializeField] private Button CreditsBtn;
    [SerializeField] private Button ExitBtn;
    [Header("Panel Settings")]
    [SerializeField] private Button SettingsBtn;
    [SerializeField] private Button BackBtnSettings;
    [SerializeField] private GameObject SettingsMenuPause;
    [Header("Sub Paneles Menu")]
    [SerializeField] private GameObject CreditsMenuPause;
    
      
    

    private void Awake()
    {
        ContinueBtn.onClick.AddListener(FunctionContinue);
        SettingsBtn.onClick.AddListener(FunctionSettings);
        CreditsBtn.onClick.AddListener(FunctionCredits);
        ExitBtn.onClick.AddListener(FunctionExit);
        BackBtnSettings.onClick.AddListener(FunctionBackSettings);
    }


    private void OnDestroy()
    {
       
        ContinueBtn.onClick.RemoveAllListeners();
        SettingsBtn.onClick.RemoveAllListeners();
        CreditsBtn.onClick.RemoveAllListeners();
        ExitBtn.onClick.RemoveAllListeners();
        BackBtnSettings.onClick.RemoveAllListeners();
    }
    /// <summary>
    /// //////////////
    /// </summary>
    private void FunctionContinue()
    {

        PauseMenu.SetActive(!PauseMenu.activeSelf);

    }
    private void FunctionSettings()
    {
        SettingsMenuPause.SetActive(!SettingsMenuPause.activeSelf);
        SettingsBtn.interactable = false;
    }
    private void FunctionBackSettings()
    {
        SettingsBtn.interactable = true;
    }

    private void FunctionCredits()
    {
        CreditsMenuPause.SetActive(!CreditsMenuPause.activeSelf);
    }
    private void FunctionExit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    /// <summary>
    /// ///////////////
    /// </summary>
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(EscBtn))
        {
          
            PauseMenu.SetActive(!PauseMenu.activeSelf);
            
        }    
        
    }
}
