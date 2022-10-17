using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera camera;
    public int range;
    [Header("Gun Damage On Hit")]
    public int damage;
    public GameObject bloodPrefab;
    public GameObject decal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, 10))
        {
            if (hit.transform.tag == "Zombie")
            {
                hit.transform.GetComponent<ZombieHealth>().Hit(damage);
                GenerateBloodEffect(hit);
            }
            else
            {
                GenerateHitEffect(hit);
            }
        }
    }

    private void GenerateHitEffect(RaycastHit hit)
    {
      

    }



    private void GenerateBloodEffect(RaycastHit hit)
    {
        GameObject bloodObject = Instantiate(bloodPrefab, hit.point, hit.transform.rotation);
    
        
    }
}
