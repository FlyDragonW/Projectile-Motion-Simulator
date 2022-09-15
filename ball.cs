using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject self;
    float timer;
    bool Grounded;
    void Start()
    {
        Instantiate(self);
    }
    void FixedUpdate()
    {
        
        timer += Time.deltaTime;
        if(timer >= 0.4f && !Grounded)
        {
            timer = 0;
            Instantiate(self,transform.position,transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Grounded = true;
    }
}
