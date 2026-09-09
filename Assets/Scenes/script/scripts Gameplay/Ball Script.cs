using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float DeltaTime;
    [SerializeField] private GameObject PauseMenu;
    private Rigidbody2D Ball;
    public float Speed = 3f;
    public float MaxSpeed = 20f;
    public MovimentPlayers LastTouch;

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
        if (PauseMenu.activeSelf)
            DeltaTime = 0f;
        else if (!PauseMenu.activeSelf)
            DeltaTime = 1f;
    }
}
