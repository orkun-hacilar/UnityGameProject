using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour
{

    public int code;

    private float disableTimer = 0;
   
    

   
    void Update()
    {
        if(disableTimer > 0)
             disableTimer =  Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player98" && disableTimer <= 0)
        {
            foreach (TeleportPad tp in FindObjectsOfType<TeleportPad>())
            {
                if (tp.code == code && tp != this)
                {
                    tp.disableTimer = 2;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;
                }
        }
        }
    }
}
