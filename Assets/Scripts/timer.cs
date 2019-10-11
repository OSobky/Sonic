using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private double timer_game = 100;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = timer_game.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        timer_game -= 1;
        TimerText.text = timer_game.ToString();

    }
}
