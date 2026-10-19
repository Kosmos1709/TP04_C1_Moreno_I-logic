using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

// Suggestion: la clase se llama MovimentPlayers (falta la 'e' de Movement) y el archivo 'Movement Players.cs', con un espacio. El mismo problema está en Timerround, Exitbotton, BottonBestof, SLiderRGB y panelsettingsscript.
// Los nombres de archivo de C# no deberían llevar espacios, y el nombre del archivo tiene que ser igual al de la clase. Renombrá desde el Project de Unity.
public class MovimentPlayers : MonoBehaviour
{
    [SerializeField] public float ScalePlayer1 = 0.5f;
    [SerializeField] public float ScalePlayer2 = 0.5f;
    public float timeScale;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject VictoryMenu;
    [SerializeField] private Rigidbody2D RigiPlayer;
    public float speed= 10f;
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;
    [SerializeField] private KeyCode LeftKey;
    [SerializeField] private KeyCode RightKey;

    [SerializeField] public float MoreSpeed = 1f;

    void Awake()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallScript ball = collision.gameObject.GetComponent<BallScript>();

        if (ball != null)
        {
            ball.LastPlayer(this);

            ball.BustSpeed(MoreSpeed);
        }
    }
        void Start()
    {
     
    }
    void Update()
    {

        // Warning: este script está en los dos jugadores, así que hay dos componentes escribiendo Time.timeScale en cada frame, más el de ComeBackMenu. Tres escrituras por frame sobre la misma variable global.
        // El control de pausa tiene que estar en un solo lugar.
        Time.timeScale = timeScale;

        if (PauseMenu.activeSelf || VictoryMenu.activeSelf)
        {
            timeScale = 0f;
        }
        else if(!PauseMenu.activeSelf || !VictoryMenu.activeSelf) 
            timeScale = 1f;
    }

    private void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(UpKey))
        {
            movement += Vector2.up;
        }
        if (Input.GetKey(LeftKey))
        {
            movement += Vector2.left;
        }
        if (Input.GetKey(RightKey))
        {
            movement += Vector2.right       ;
        }
        if (Input.GetKey(DownKey))
        {
            movement += Vector2.down;
        }
        movement = movement.normalized;
        // Warning: escribís rb.position directo, que teletransporta el cuerpo y saltea la detección de colisiones del motor. La consigna pide mover con físicas.
        // Usá RigiPlayer.MovePosition(RigiPlayer.position + movement * speed * Time.fixedDeltaTime), o AddForce si querés inercia.
        RigiPlayer.position += movement * speed * Time.fixedDeltaTime;
    }
}
