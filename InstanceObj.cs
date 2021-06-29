using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObj : MonoBehaviour {

	public GameObject prefabA;
	public GameObject prefabB;
	private static int count=0;
	private static float lastTime=0;
	public int shoeCount=0;
	private void Start() {
		lastTime=Time.time;
	}

	private void Update() {
		if(count<30){
			bool alt=Input.GetButton("Fire1");
			if(Time.time-lastTime>0.1f){
				if(prefabA!=null && !alt){
					Instantiate(prefabA,Vector3.zero,transform.rotation);
				}
				if(prefabB!=null && !alt){
					Instantiate(prefabB,Vector3.zero,transform.rotation);
				}
				lastTime=Time.time;
				count++;
				shoeCount=count;
			}
		}
	}
}
