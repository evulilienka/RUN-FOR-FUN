using UnityEngine;
using System.Collections;

public class Player2Control : Controls {
    
    public int speed = 7;
	public bool facingRight = true;
	public Animator anim;

	void Start(){
		//anim = GetComponent<Animator>();
	}

    void FixedUpdate()
	{		
		this.GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(Input.GetAxis ("Horizontal")));
			if (Input.GetButton ("Player2_Horizontal")) {
						if (Input.GetAxis ("Player2_Horizontal") < 0) {
								//this.transform.eulerAngles = new Vector2(0, 180);
								speed = Mathf.Abs (speed);
								transform.Translate (Input.GetAxis ("Player2_Horizontal") / speed * Vector3.right);

						} else {
								this.transform.eulerAngles = new Vector2 (0, 0);
								speed = -1 * Mathf.Abs (speed);
								transform.Translate (Input.GetAxis ("Player2_Horizontal") / speed * Vector3.left);
						}

				}
		if (Input.GetAxis ("Player2_Horizontal") > 0 && !facingRight) {
			Flip ();
		} else if (Input.GetAxis ("Player2_Horizontal") < 0 && facingRight) {
			Flip ();		
		}



    }
	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
