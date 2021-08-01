using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{
    
    public GameObject obj;
    private Vector3 mOffset;
   


    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(

            obj.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = obj.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }


    void Update()
    {
        if(obj.transform.position.y<-8f)
        {
            Debug.Log("object fell");
            obj.transform.position = new Vector3(0f, 5f, 0f);
        }
    }

 


}