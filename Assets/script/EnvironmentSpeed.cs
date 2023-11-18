using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpeed : MonoBehaviour
{
    public float Speed;

    [SerializeField]
    private Renderer EnvironmentRenderer;

    // Update is called once per frame
    void Update()
    {
        EnvironmentRenderer.material.mainTextureOffset += new Vector2(Speed * Time.deltaTime, 0);
    }
}
