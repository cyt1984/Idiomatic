
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Status : MonoBehaviour {

	public Text points, word;

	public string cacheWord = "";

	private EnemyScript enemyScript;

	private void Start () {
		points = GetUiElement ("Points");

		word = GetUiElement ("Word");

		enemyScript = GameObject.Find ("Enemy").GetComponent<EnemyScript> ();
		
		UpdateWordStatus ();
	}

	public Text GetUiElement (string nameElementCanvas) {
		return transform.Find (nameElementCanvas).gameObject.GetComponent<Text> ();
	}

	public void SetUiElementText (Text textElementCanvas, string txt) {
		textElementCanvas.text = txt;
	}

	public void UpdateWordStatus () {
		cacheWord = enemyScript.GetEnemyText (Random.Range (0, enemyScript.quantityEnemys), "Text Enemy");

		SetUiElementText (word, cacheWord);
	}

	public void SetPoints (int pts) {
		this.points.text = pts.ToString () + " Points";
	}

}