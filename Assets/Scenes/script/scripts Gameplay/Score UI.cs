using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;   

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreP1Text;
    [SerializeField] private TMP_Text ScoreP2Text;
    [SerializeField] private Score Score;
    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Warning: los dos textos se reconstruyen en cada frame para mostrar un número que solo cambia cuando hay gol. Son dos strings nuevos por frame.
        // Actualizá el marcador desde Score, cuando el punto se suma.
        ScoreP1Text.text = $"{Score.ScoreP1:00}";
        ScoreP2Text.text = $"{Score.ScoreP2:00}";
    }
}
