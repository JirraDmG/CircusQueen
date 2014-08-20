using UnityEngine;
using System.Collections;

public class OnDeathMenu : MonoBehaviour {

    public Transform Ball;
    public Rect menuBackground;
    public Rect buttonPosition;
    public Rect button2Position;

    public bool IsPlayerDead
    {
        get;
        set;
    }

    public void OnGUI()
    {

        if (IsPlayerDead == true)
        {
            GUI.Box(menuBackground, "");
            if (GUI.Button(buttonPosition, "Restart"))
            {
                Ball.GetComponent<AcceleredBallMovement>().Restart();
            }
            if (GUI.Button(button2Position, "Quit Game"))
            {
                Application.Quit();
            }
        } 
    }

}