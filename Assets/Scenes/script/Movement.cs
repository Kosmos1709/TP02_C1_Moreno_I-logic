using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float TimeScale;
    [SerializeField] private Button PLAY;

        //hace que sea visible en el inspector 
    private SpriteRenderer Sr;

    //herramientas de movimiento//
    //con esto muestro en unity las variables para modificar a cualquier spirte que quiera.
    //asi no escribo varios scrpts y los asigno de una forma mas facil.

    [Header("Controles de Movimiento")] //esto es un titulo para el inspector
    [SerializeField] private KeyCode Up = KeyCode.W; //[SerializeField] Sirve para que la variable sea visible en el inspector pero no sea publica, es decir que no pueda ser accedida desde otro script.
    [SerializeField] private KeyCode Down = KeyCode.S;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode Right = KeyCode.D;
    
    [Header("controles de rotacion")]
    [SerializeField] private KeyCode RotateLeft = KeyCode.Q;
    [SerializeField] private KeyCode RotateRight = KeyCode.E;

    [Header("controles de color")]
    [SerializeField] private KeyCode SwitchColor = KeyCode.R;

    private void Awake()
    {
           PLAY.onClick.AddListener(FunctionOnClick);
    }
    private void OnDestroy()
    {
        PLAY.onClick.RemoveAllListeners();
    }
    private void FunctionOnClick()
    {
        TimeScale = 1f;
    }
    void Start()
    {
        Debug.Log("¡¡VAMOS CON TODO!!"); //Ejecuta una vez antes del primer frame

        Sr = GetComponent<SpriteRenderer>(); //a la variable sr le di el componente del mismo tipo que pertenece.
        //sino me daria todo tipo de componentes y yo necesito de tipo spriterender ahora, asi que lo aclaro una sola vez en start

    }

    void Update()
    {
        // Corre Una vez por frame "Importante"

        // aqui la entrada de una tecla entrante con las variable asignadas anteriormente
        // que al pasar ejecutan un movimiento constante a base de una velocidad por segundo "time.deltatime"

        Time.timeScale = TimeScale;
        if (Input.GetKey(Up))
            transform.Translate(Vector2.up * speed * Time.deltaTime* TimeScale);

        if (Input.GetKey(Down))
            transform.Translate(Vector2.down * speed * Time.deltaTime * TimeScale);
            
        if (Input.GetKey(left))
            transform.Translate(Vector2.left * speed * Time.deltaTime * TimeScale);

        if (Input.GetKey(Right))
            transform.Translate(Vector2.right * speed * Time.deltaTime * TimeScale);

        if (Input.GetKeyDown(RotateLeft))
            transform.Rotate(0f, 0f, 10f * Time.timeScale) ;

        if (Input.GetKeyDown(RotateRight))
            transform.Rotate(Vector3.forward * -10 * Time.timeScale);
        //al soltar la letra R se crearan 2 floats osea variables con numeros desimales de 0 a 1
        //y aparte un int variable de entero para generar numeros aleatorios
        //con los que usare para crear un color random con el sistema rgb
        if (Input.GetKeyUp(SwitchColor))
        {
            float r = Random.value;
            float g = Random.Range(0f, 1f);
            int b = Random.Range(1, 256);
            //aqui digo que "Sr" mi variable adopte un color que es igual a "new color" o "generar un color"
            // con las variables que almacenan un numero random para crearlo
            Sr.color = new Color(r, g, b);
        }
    }
}