using UnityEngine;
using UnityEngine.UI;
//using InityEngine.UI refers to a updated score in the UI
public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    void Update () {
        scoreText.text = player.position.z.ToString("0");
        //ToString is important othewise an error will occur  
	}
}
