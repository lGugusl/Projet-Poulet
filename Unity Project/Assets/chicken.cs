using UnityEngine;
using System.Collections;

public class chicken : MonoBehaviour {



	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.name=="Player") {
			//Fabric.EventManager.Instance.PostEvent("death",gameObject);
			//Pas le temps de trouver la routine pour attendre 1 seconde avant le reload
			Application.LoadLevel (0);


		}
	}
	


}
