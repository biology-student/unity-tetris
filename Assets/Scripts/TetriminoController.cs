using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetriminoController : MonoBehaviour
{
    float delta = 0;
    float span = 1.0f;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span){
            this.delta = 0;
            
            transform.Translate(0, -0.5f, 0);
        }
    }
}
