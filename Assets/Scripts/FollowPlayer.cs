using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 6, -8);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // add camera position offset - above and behind
        transform.position = player.transform.position + cameraOffset;
    }
}
