using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] balls;
    public float time;

    private void Start() 
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {

        float xFloat = transform.position.x;
        float yFloat = transform.position.y;
        float zFloat = transform.position.z;
        
        while(true){

        GameObject ball = Instantiate(balls[Random.Range(0, balls.Length)], new Vector3(Random.Range(19, 2*xFloat-19), yFloat, zFloat),Quaternion.identity);
        //new Vector3(Random.Range(-width,width), 6, 0)
        //new Vector3Int(transform.position.x + width ,transform.position.y, 0f)
        ball.transform.parent = transform;
        yield return new WaitForSeconds(time);}
    }
}
