using UnityEngine;
using System.Collections;

public class Treasure : MonoBehaviour {

	//public int value = 10;    //alınan itemin kazandırdığı deger
	//public GameObject explosionPrefab;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {


			/* Game Manager erişim sağlayarak uı kısmından deger güncelleme
			 * if (GameManager.gm!=null)
			{
				
				GameManager.gm.Collect (value);
			}*/
			
			
		/*	if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}*/
			
			// collection u ortadan kaldırma
			Destroy (gameObject);
		}
	}
}
