using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plybltdestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collisionInfo){
        if(collisionInfo.tag=="PlyBullet"){
            Destroy(collisionInfo.gameObject);
        }
    }
}
