using UnityEngine;
using System.Collections;

public class AnimationTransition : MonoBehaviour {
	public string parameterName;

	private bool changeAnimation = false;
	private int counter = 0;

	// Update is called once per frame
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			changeAnimation = !changeAnimation;
			this.GetComponent<Animator>().SetBool(parameterName, changeAnimation);
		}
	}

	void AnimationEvent(string parameter)
	{
		counter++;
		print ("Animation event happened " + counter + " times with parameter '" + parameter + "'.");
	}
}
