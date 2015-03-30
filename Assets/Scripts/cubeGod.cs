using UnityEngine;
using System.Collections;

public class cubeGod : MonoBehaviour {

	public Transform blueprint; // assign this in the inspector
	int cubeCountMax = 100;
	float cubeSpawnRadius = 10f;

	// Use this for initialization
	void Start () {

//		cubeCountMax = Random.Range (100, 1000);
		cubeSpawnRadius = Random.Range (-10, 100);

	

//		int cubeCount = 0;
//		while ( cubeCount < cubeCountMax ) {
//			Instantiate ( blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation ); //on unit sphere will put cubes on the outside of the area
//			cubeCount++;
//		}

		for ( int anotherCounter = 0; anotherCounter < 500; anotherCounter++ ) {
			Instantiate ( blueprint, Random.insideUnitSphere * cubeSpawnRadius, Random.rotation ); //on unit sphere will put cubes on the outside of the area

		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel ( Application.loadedLevel );
		}
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			makeRandomCube();
		}

	}

	void makeRandomCube() {
		Instantiate ( blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation );
	}


}
