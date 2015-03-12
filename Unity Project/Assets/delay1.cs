using UnityEngine;
using System.Collections;

public class delay1 : MonoBehaviour {
	private bool marche;

	public void RayOff () {
		renderer.enabled = false;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!marche){
		if (Input.GetButtonDown("Horizontal")||Input.GetButtonDown("Vertical")) {
			renderer.enabled=true;
			marche = true;
			}
		}
	}


}
