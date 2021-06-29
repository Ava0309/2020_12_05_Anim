using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowYou : MonoBehaviour {

	public Transform TargetObj;
	public Animator animator;


	private void Update() {
		if(Vector3.Distance(TargetObj.position,animator.rootPosition)>2){
			animator.SetFloat("Speed",1);
			Vector3 currentDir=animator.rootRotation*Vector3.forward;
			Vector3 WantedDir=
			(TargetObj.position-animator.rootPosition).normalized;
			if(Vector3.Dot(currentDir,WantedDir)>0){
				animator.SetFloat("Direction",
				Vector3.Cross(currentDir,WantedDir).y);
			}else{
				animator.SetFloat("Direction",
				Vector3.Cross(currentDir,WantedDir).y>0?1:-1);
			}
		}else{
			animator.SetFloat("Speed",0);
		}
	}
}
