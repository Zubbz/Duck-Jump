using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleTransition : MonoBehaviour
{
    public Transform TitleTransit, StartTransit, OptionTransit, QuitTransit;

    void Start()
    {

        Debug.Log("Animation Played");

        TitleTransit.localPosition = new Vector2(904, 168);
        StartTransit.localPosition = new Vector2(904, -6);
        OptionTransit.localPosition = new Vector2(904, -77);
        QuitTransit.localPosition = new Vector2(904, -148);

        TitleTransit.LeanMoveLocal(new Vector2(-30, 168), 2).setEaseOutQuart();
        StartTransit.LeanMoveLocal(new Vector2(0, -6), 2).setEaseOutQuart();
        OptionTransit.LeanMoveLocal(new Vector2(0, -77), 2).setEaseOutQuart();
        QuitTransit.LeanMoveLocal(new Vector2(0, -148), 2).setEaseOutQuart();

    }
}
