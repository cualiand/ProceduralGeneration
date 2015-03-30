using UnityEngine;
using System.Collections;

public class Pathinstantiate : MonoBehaviour {

	public Transform blueprint;
	public Transform floorTile;
	public Transform gridCube;
	public int tileCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		float randomNumber = Random.Range( 0.0f, 1.0f );

		if ( tileCounter < 50 ) {
			float randomNumber = Random.Range( 0.0f, 1.0f );
			if ( randomNumber < 0.25f ) {
				transform.Rotate( 0f, 90f, 0f ); //check this out later
			}
			if ( randomNumber > 0.25f && randomNumber < 0.5f ) {
				transform.Rotate ( 0f, -90f, 0f ); //check this out later
			}
			Instantiate ( floorTile, transform.position, Quaternion.identity ); //quaterion.identity = quaternion.euler (0,0,0)
			blueprint.transform.Translate ( 5f, 0f, 0f );

			float randomNumber2 = Random.Range( 0.0f, 1.0f );
			if ( randomNumber2 > 0.98f ) {
				Instantiate ( gridCube, transform.position, Quaternion.identity );
			}
			tileCounter++;
		}


	
		else {
			Destroy ( gameObject );
			}
		
//		if ( Input.GetKeyDown (KeyCode.R) ) {
//			Application.LoadLevel ( Application.loadedLevel );
//		}

		}

	}
