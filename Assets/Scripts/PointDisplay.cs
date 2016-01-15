using UnityEngine;
using UnityEngine.UI;

public class PointDisplay : MonoBehaviour {	

	void Start ()
	{
	    int points = GameObject.FindGameObjectWithTag("GameManager").GetComponent<CountPoint>().points;
	    gameObject.GetComponent<Text>().text = points + " points";
	}		
}
