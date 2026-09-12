using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class MovimentPlayers : MonoBehaviour
{
    [SerializeField] public float ScalePlayer1 = 1f;
    [SerializeField] public float ScalePlayer2 = 1f;
    public float timeScale;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private Rigidbody2D RigiPlayer;
    public float speed= 10f;
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;
    [SerializeField] private KeyCode LeftKey;
    [SerializeField] private KeyCode RightKey;

    [SerializeField] public float MoreSpeed = 1f;

    void Awake()
    {
        RigiPlayer = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector3(0.6f, ScalePlayer1, 0.6f);
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

        Time.timeScale = timeScale;

        if (PauseMenu.activeSelf)
        {
            timeScale = 0f;
        }
        else if(!PauseMenu.activeSelf) 
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
        RigiPlayer.position += movement * speed * Time.fixedDeltaTime;
    }
}
