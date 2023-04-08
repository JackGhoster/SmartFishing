using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownAndTimer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _countdown,_timer;

    private float _countdownTimer = 6;
    private bool _countdownStarted = false;
    private string[] _countdownWords = new string[3] {"Ready?", "Set", "Go"};
    private int _countdownIndex = 0;

    private bool _timerStarted = false;

    private void Update()
    {
        
    }

    private void Start()
    {
        _countdownStarted = true;
        StartCoroutine(TickCoroutine());
    }

    private void Countdown()
    {
        if((int)_countdownTimer % 2 == 0 )
        {
            //Text
        }

    }
    
    IEnumerator TickCoroutine()
    {
        while(_countdownStarted == true)
        {         
            EventManager.Instance.TickTime();
            yield return new WaitForSeconds(1);
        }
            
    }

    private void Awake()
    {
        //EventManager.Instance.OnCirclesSpawned += StartCountdown;
    }

    private void OnDisable()
    {
        //EventManager.Instance.OnCirclesSpawned -= StartCountdown;
    }




}
