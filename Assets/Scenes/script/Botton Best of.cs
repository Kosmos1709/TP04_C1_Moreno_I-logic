using System;
using UnityEngine;
using UnityEngine.UI;

public class BottonBestof : MonoBehaviour
{
    [SerializeField] private Button BestOf3;
    [SerializeField] private Button BestOf5;
    [SerializeField] private Button BestOf7;
    [SerializeField] private GameObject ScoreBall;
    private Score score;


    private void Awake()
    {
        BestOf3.onClick.AddListener(() => SetBestOf3());
        BestOf5.onClick.AddListener(() => SetBestOf5());
        BestOf7.onClick.AddListener(() => SetBestOf7());
    }

    void Start()
    {
        score =ScoreBall.GetComponent<Score>();
    }

    private void OnDestroy()
    {
        BestOf3.onClick.RemoveAllListeners();
        BestOf5.onClick.RemoveAllListeners();
        BestOf7.onClick.RemoveAllListeners();
    }




    public void SetBestOf3()
    {
        if (score != null)
        {
            score.BestOf = 3;
            Debug.Log("Best of 3 selected");
        }
    }

    public void SetBestOf5()
    {
        if (score != null)
        {
            score.BestOf = 5;
            Debug.Log("Best of 5 selected");
        }
    }

    public void SetBestOf7()
    {
        if (score != null)
        {
            score.BestOf = 7;
            Debug.Log("Best of 7 selected");
        }
    }   




    void Update()
    {
        
    }
}
