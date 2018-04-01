using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    GameObject playerObj;
    Vector3 cammeraOffSet;
	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("stick man rig/Bone002");
        cammeraOffSet = new Vector3(-1,1,1);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerObj.transform.position + cammeraOffSet;
	}
}
