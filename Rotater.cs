using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
	
	// Update is called once per frame, no forces so we can use update not lateupdate
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //smoothes rotate
	}
}
