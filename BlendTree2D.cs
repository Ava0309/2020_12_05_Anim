using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree2D : MonoBehaviour {
	public Animator animator;

	private float xVal=1.5f;
	private float yVal=1.5f;
	
	void Update () {
		float h=Input.GetAxis("Horizontal")*xVal;
		float v=Input.GetAxis("Vertical")*yVal;
		animator.SetFloat("ValX",h);
		animator.SetFloat("ValY",v);
	}
}
