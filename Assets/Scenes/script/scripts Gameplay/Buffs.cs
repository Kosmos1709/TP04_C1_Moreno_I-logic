using UnityEngine;

public class Buffs : MonoBehaviour
{

    public float bonusMultiplier = 2f;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallScript ball =
            collision.GetComponent<BallScript>();
            if (ball != null)
            {
                if (ball.LastTouch != null)
                {
                   ball.LastTouch.MoreSpeed += bonusMultiplier;
                }

                Destroy(gameObject);
    
        }
    
    }
    // Suggestion: Start y Update están vacíos. Pasa lo mismo en Ball Script, Change color For limit, ComeBackMenu, EndGame, Movement Players, RandomColorPlayer, SLider RGB, Scale Sliders, Score UI, Timer round, Botton Best of y Exit botton.
    // Unity los llama igual aunque estén vacíos: borralos y el archivo queda más corto y más claro.
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
