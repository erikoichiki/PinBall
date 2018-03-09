using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour {
	 
	public GameObject scoreText;

	private int score = 0;


	// Use this for initialization
	void Start () { 
		score = 0;
		this.scoreText = GameObject.Find("ScoreText");

	}


	// Update is called once per frame
    void Update () {
		
		this.scoreText.GetComponent<Text> ().text = score.ToString ();
	}

	void OnCollisionEnter(Collision collision ){
		
		if (collision.gameObject.tag== "SmallStarTag") {
			this.score += 50;


		}  else if (collision.gameObject.tag== "LargeStarTag") {
			this.score += 100;
		

		}

}
}