using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBrain : MonoBehaviour
{
    private void Update() {
        if(transform.position.y <= -13)
            Destroy(gameObject);
    }
}
