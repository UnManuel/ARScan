// by @unmanuel

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour {

	public bool faceCamera = false;
    
    void Update() {
    	if(faceCamera) {
			transform.localEulerAngles = -Camera.main.transform.localEulerAngles;
			transform.LookAt(Camera.main.transform.position);
    	}
    }
}
