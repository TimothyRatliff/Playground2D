using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //associate this script with a object in the inspector
    public GameObject player;
    //what is the offset of the camera to begin with?
    Vector3 offset;

	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	//using lateUpdate prevents lag
    //lateUpdate is the last function called on the game
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
	}
}
