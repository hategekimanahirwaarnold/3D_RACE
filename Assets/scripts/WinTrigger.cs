
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // Update is called once per frame
    void OnTriggerEnter ()
    {
         gameManager.CompleteLevel();
    }
}
