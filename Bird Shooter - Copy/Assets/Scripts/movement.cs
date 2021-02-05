using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firePoint;
    public float speed=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.position+=new Vector3(horizontal*speed*Time.deltaTime,0f,0f);
        if(Input.GetMouseButtonDown(0)){
            fire();
        }


        
    }
    void fire(){
        Instantiate(bulletprefab,firePoint.position,Quaternion.identity);
    }

}
