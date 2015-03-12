using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	public swpanzor appel;
	public delay calloff;
	public delay1 calloff1;

	



	void OnTriggerStay(Collider other) {
		if (other.gameObject.name=="Player") {
			if (Input.GetButtonDown("Fire1")) {
				appel.Spawn();
				//calloff.LightOff();
				//calloff1.RayOff();
				Fabric.EventManager.Instance.PostEvent("Music",gameObject);
			}
		}
	}
}
