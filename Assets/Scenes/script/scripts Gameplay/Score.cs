using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    [Header("Score Players")]
    [SerializeField] public int ScoreP1;
    [SerializeField] public int ScoreP2;
    [Header("Game Objects")]
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject RightWall;
    [SerializeField] private GameObject LeftWall;
    [SerializeField] private GameObject triggerleft;
    [SerializeField] private GameObject triggerright;
    [SerializeField] public EndGame endgame;
    public bool EndOFGame =false;
    public int BestOf;
    private int Goal;
    public BallScript ballScript;
    public Timerround timerRound;
    


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
            timerRound.ResetTimer();

           
        }
        if (collision.gameObject == LeftWall)
        {
            ScoreP2++;
            Debug.Log("Player 2 Score: " + ScoreP2);
            ballScript.ResetSpeed();
            transform.position = Vector2.zero;
            timerRound.ResetTimer();



        }
    }

    void OnTriggerStay2D(Collider2D collider2D)
    {

        
        if (collider2D.gameObject == triggerleft && timerRound.roundTime == 0)
        {
            ScoreP1++;
            timerRound.ResetTimer();
            ballScript.ResetSpeed();
            transform.position = Vector2.zero;

        }
        if (collider2D.gameObject == triggerright && timerRound.roundTime == 0)
        {
            ScoreP2++;
            timerRound.ResetTimer();
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
            EndOFGame = true;
            endgame.Player1Win();
        }
        if (ScoreP2 >= Goal)
        {
            Debug.Log("Player 2 Wins!");
            Time.timeScale = 0f;
            EndOFGame = true;
            endgame.Player2Win();


        }

    }
}
