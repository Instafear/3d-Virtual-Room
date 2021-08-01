using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobj : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(this.name);
            this.transform.Rotate(0,90,0);
        }
    }
   
}
