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
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
