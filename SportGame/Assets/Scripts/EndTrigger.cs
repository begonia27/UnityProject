using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            GameManager.CompleteLevel();
        }
    }
}
