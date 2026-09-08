using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float DeltaTime;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D ball;

    private void Awake()
    {
        ball = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        ball.linearVelocity = new Vector2(1f, 1f).normalized * speed;

    }
    private void FixedUpdate()
    {

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
