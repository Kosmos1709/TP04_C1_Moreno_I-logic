using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    [Header("Score Players")]
    // Warning: ScoreP1, ScoreP2, EndOFGame, BestOf, endgame, ballScript y timerRound son public. Con [SerializeField] ya los ves en el inspector; el public solo abre la puerta a que cualquiera los pise.
    // Dejalos private y exponé lo que otro script necesita leer (el marcador) como property de solo lectura.
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

        
        // Bug: el punto por tiempo va al jugador equivocado. 'trigger left' está en x = -1.44, o sea la mitad izquierda, que es el lado del jugador 1 (se ve en el OnCollisionEnter2D de arriba: la pelota contra RightWall le suma al jugador 1).
        // La consigna dice que al cumplirse el tiempo se le hace un gol AL jugador que tiene la pelota de su lado, así que si la pelota quedó a la izquierda el punto es del jugador 2. Están invertidas las dos ramas.
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
            // Warning: este Debug.Log está adentro del Update y la condición sigue siendo verdadera después de ganar, así que escribe una línea por frame hasta que se cierre el juego. Lo mismo con el de la línea 104.
            // Además Time.timeScale = 0f también se reasigna en cada frame. Mové el bloque de victoria a un método que se llame una sola vez, desde donde se suma el punto.
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
