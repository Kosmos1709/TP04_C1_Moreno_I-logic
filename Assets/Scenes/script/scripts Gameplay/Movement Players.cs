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
        transform.localScale = new Vector3(1f, ScalePlayer1, 1f);
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
        if (Input.GetKey(UpKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.up * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(LeftKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.left * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(RightKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.right * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(DownKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.down * speed * Time.fixedDeltaTime);
        }
    }
}
