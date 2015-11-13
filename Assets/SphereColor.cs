using UnityEngine;
using System.Collections;

public class SphereColor :  CaracteristicasObjeto {
	public override void mudarCor() {
		Renderer rend = GetComponent<Renderer>();
		int randomNumber = Random.Range(0,3); //sorteia numeros entre 0 e 2
		if (randomNumber == 0) {
			rend.material.color = Color.green;
		} 
		else {
			rend.material.color = Color.yellow;
		}
	}
}