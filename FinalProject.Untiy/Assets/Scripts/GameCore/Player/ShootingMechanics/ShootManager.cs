using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{

    RaycastHit _objectOnHitLine;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, transform.forward,out _objectOnHitLine))
        {
            GameObject _gameObjectOnHitLine = _objectOnHitLine.transform.gameObject;
            Debug.DrawLine(transform.position, _gameObjectOnHitLine.transform.position, Color.red); 
            if(Input.GetMouseButtonDown(0))
            {  
                Destroy(_gameObjectOnHitLine);
            }
        }
    }
}
