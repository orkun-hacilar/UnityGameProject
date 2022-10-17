using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject bulletPrefab;
   public Camera playerCamera;

   private void Start()
   {
      
   }


   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
          GameObject bulletObject = Instantiate(bulletPrefab);
          bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
          bulletObject.transform.forward = playerCamera.transform.forward;
      }
   }
}
