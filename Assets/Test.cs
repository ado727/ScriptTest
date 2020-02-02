using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Start () {

		int[] array = new int[5];

		array [0] = 10;
		array [1] = 90;
		array [2] = 90;
		array [3] = 70;
		array [4] = 20;

		for (int a = 0; a < 5; a++) {
			Debug.Log (array [a]);
		}
		for (int b = 4; b < 5; b--){
			Debug.Log (array [b]);
		}

	}

	void Update () {

	}
}