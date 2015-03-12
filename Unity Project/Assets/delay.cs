using UnityEngine;
using System.Collections;

public class delay : MonoBehaviour {
	private bool marche;

	public void LightOff () {
		light.enabled = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!marche){
		if (Input.GetButtonDown("Horizontal")||Input.GetButtonDown("Vertical")) {
			light.enabled=true;
			Fabric.EventManager.Instance.PostEvent("lightswitch",gameObject);
			marche = true;
			}
		}

	}



}
