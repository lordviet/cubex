using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager2 gameManager;
    
    //void is used to detect collision, can be replaced with OnCollisionEnter but it is a trigger
    
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }


}
