using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Example());
	}
	
	IEnumerator Example()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
}
