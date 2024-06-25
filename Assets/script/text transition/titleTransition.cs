using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleTransition : MonoBehaviour
{
    public Transform TitleTransit, StartTransit, QuitTransit;

    void Start()
    {
        //  Handles the transition of all texts when the game starts or goes to the Main Menu
        Debug.Log("Animation Played");

        TitleTransit.localPosition = new Vector2(904, 168);
        StartTransit.localPosition = new Vector2(904, -6);
        QuitTransit.localPosition = new Vector2(904, -148);

        TitleTransit.LeanMoveLocal(new Vector2(-30, 168), 2).setEaseOutQuart();
        StartTransit.LeanMoveLocal(new Vector2(0, -6), 2).setEaseOutQuart();
        QuitTransit.LeanMoveLocal(new Vector2(0, -148), 2).setEaseOutQuart();

    }
}
