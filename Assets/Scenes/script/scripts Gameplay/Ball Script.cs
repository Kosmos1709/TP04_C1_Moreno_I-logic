using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Warning: DeltaTime se calcula en cada frame y no lo lee nadie, ni en este script ni en ningún otro. Además el else if de abajo lo deja en 1 en vez de en Time.deltaTime.
    // Borralo. Y Speed, MaxSpeed y LastTouch pueden ser private: ya tenés BustSpeed, ResetSpeed y LastPlayer como puerta de entrada.
    public float DeltaTime;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject VictoryMenu;

    private Rigidbody2D Ball;
    public float Speed = 3f;
    public float MaxSpeed = 20f;
    public MovimentPlayers LastTouch;
    private Timerround timerRound;


    private void Awake()
    {
        Ball = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Ball.linearVelocity = new Vector2(1f, 1f).normalized * Speed;

    }

    public void ResetSpeed()
    {
        Speed = 3f;
        Ball.linearVelocity = Ball.linearVelocity.normalized * Speed;
    }
    public void BustSpeed(float amount)
    {
        Speed += amount;
        Speed = Mathf.Min(Speed, MaxSpeed);
        Ball.linearVelocity = Ball.linearVelocity.normalized * Speed;
    }
   


    public void LastPlayer(MovimentPlayers Player) {
        LastTouch = Player;
        }



    void Update()
    {
        DeltaTime=Time.deltaTime;
        if (PauseMenu.activeSelf || VictoryMenu.activeSelf)
            DeltaTime = 0f;
        else if (!PauseMenu.activeSelf || !VictoryMenu.activeSelf)
            DeltaTime = 1f;
    }
}
