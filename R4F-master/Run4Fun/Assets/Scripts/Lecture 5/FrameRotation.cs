using UnityEngine;
using System.Collections;

public class FrameRotation : MonoBehaviour {
	public int speed = 10;
	internal int visibleInScripts;
	public int VisibleInScripts { get; set; }
	private int visibleOnlyInThisScript;

	// Update is called once per frame
	void Update () {
		//print (Time.deltaTime);
		this.transform.Rotate (Vector3.up * Time.deltaTime * speed * 50);
	}
}
