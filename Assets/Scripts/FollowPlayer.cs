using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	// Debug.log is a message to the console
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
        
	}
}
