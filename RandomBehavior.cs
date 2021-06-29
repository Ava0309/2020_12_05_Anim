using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBehavior : MonoBehaviour {

	public Animator animator;

	private Vector3 TargetPos=Vector3.zero;

	private void Update() {
		int random=Random.Range(0,50);
		animator.SetBool("JumpBool",random==30);

		if(Vector3.Distance(TargetPos,animator.rootPosition)>5){
			animator.SetFloat("Speed",1);
			Vector3 currentDir=animator.rootRotation*Vector3.forward;
			Vector3 WantedDir=
			(TargetPos-animator.rootPosition).normalized;
			if(Vector3.Dot(currentDir,WantedDir)>0){
				animator.SetFloat("Direction",
				Vector3.Cross(currentDir,WantedDir).y);
			}else{
				animator.SetFloat("Direction",
				Vector3.Cross(currentDir,WantedDir).y>0?1:-1);
			}
		}else{
			animator.SetFloat("Speed",0);
			if(animator.GetFloat("Speed")<0.01f){
				TargetPos=new Vector3(Random.Range(-25,25),0,Random.Range(-25,25));
			}
		}
	}
}
