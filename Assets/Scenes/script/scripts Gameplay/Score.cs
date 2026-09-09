using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int ScoreP1;
    [SerializeField] private int ScoreP2;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject RightWall;
    [SerializeField] private GameObject LeftWall;
    public int BestOf;
    private int Goal;
   public BallScript ballScript;
    void Start()
    {
        BestOf = 5;
        ScoreP1 = 0;
        ScoreP2 = 0;
        ballScript = GetComponent<BallScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == RightWall)
        {
            ScoreP1++;
            Debug.Log("Player 1 Score: " + ScoreP1);
            ballScript.ResetSpeed();
            transform.position = Vector2.zero;


           
        }
        if (collision.gameObject == LeftWall)
        {
            ScoreP2++;
            Debug.Log("Player 2 Score: " + ScoreP2);
            ballScript.ResetSpeed();
            transform.position = Vector2.zero;

            

        }
    }

    void Update()
    {
        if(BestOf == 3)
        {
            Goal = 2;
        }
        if (BestOf == 5)
        {
            Goal = 3;
        }
        if (BestOf == 7)
        { 
            Goal = 4;
        }

        if (ScoreP1 >= Goal)
        {
            Debug.Log("Player 1 Wins!");
            Time.timeScale = 0f;
        }
        if (ScoreP2 >= Goal)
        {
            Debug.Log("Player 2 Wins!");
            Time.timeScale = 0f;
        }

    }
}
