using UnityEngine;
using System.Collections;

public class swpanzor : MonoBehaviour {
	public GameObject Spwancotcot;

	public void Spawn () {


		for (int i=0; i<25; i++)
			Instantiate (Spwancotcot, transform.position + new Vector3 (Random.Range (-45f, 45f), 0, Random.Range (-45f, 45f)), transform.rotation);

	}
}
