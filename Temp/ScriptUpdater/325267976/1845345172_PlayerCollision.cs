using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(PlayerCollision collisionInfo)
    {
        Debug.Log(collisionInfo.GetComponent<Collider>().name);
    }
}
