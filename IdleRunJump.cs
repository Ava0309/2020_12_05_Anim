using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRunJump : MonoBehaviour {

	public Animator animator;

	private void Update() {

		AnimatorStateInfo info=animator.GetCurrentAnimatorStateInfo(0);
		if(info.IsName("Base Layer.Run")){
			if(Input.GetButton("Fire1")){
				animator.SetBool("JumpBool",true);
			}
		}else{
			animator.SetBool("JumpBool",false);
		}

		if(Input.GetButtonDown("Fire2")){
			animator.SetBool("WaveBool",!animator.GetBool("WaveBool"));
		}

		float v=Input.GetAxis("Vertical");
		animator.SetFloat("Speed",v);
		float h=Input.GetAxis("Horizontal");
		animator.SetFloat("Direction",h);
	}
}
