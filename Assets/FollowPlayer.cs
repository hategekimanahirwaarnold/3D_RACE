using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // let the camera follow a player with a specific offset
        transform.position = player.position + offset;
    }
}
