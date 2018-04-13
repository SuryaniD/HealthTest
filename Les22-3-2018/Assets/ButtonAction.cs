using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour {

	public void Onclick() {
	transform.localScale += new Vector3(0.2f, 0.0f, 0.0f);
	}


	public void OnclickKrimp() {
		transform.localScale -= new Vector3(0.2f, 0.0f, 0.0f);
	}

}

