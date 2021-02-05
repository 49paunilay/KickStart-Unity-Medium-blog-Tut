using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject birdPrefab;
    public float interval=0.3f;
    float time=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
      
        if(time>interval){
            Instantiate(birdPrefab,new Vector3(transform.position.x,Random.Range(3.25f,4.29f),0f),Quaternion.identity);
            time=0;
        }

        
    }
}
