using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	Vector3 pos;
	public Transform blueprint;
	public Transform floorTile;
	public Transform wallTile;
	public Transform pathCube;


	// Use this for initialization
	void Start () {
		for ( int x = 0; x < 5; x++ ) {
			for ( int z = 0; z < 5; z++ ) {
				pos = new Vector3 ( x * 5, 0, z * 5 ) + blueprint.transform.position;
				float randomNumber = Random.Range ( 0.0f, 1.0f );
				if ( randomNumber < 0.7f ) {
					Instantiate ( floorTile, pos, Quaternion.identity );
				}
				if ( randomNumber > 0.7f && randomNumber < 0.95f ) {
					Instantiate ( wallTile, pos, Quaternion.identity );
				}
				float randomNumber2 = Random.Range ( 0.0f, 1.0f );
				if ( randomNumber2 > 0.9f ) {
					Instantiate ( pathCube, transform.position, Quaternion.identity );
				}
				else {
					continue;
				}

			}		
		}
		//Destroy ( gameObject );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
