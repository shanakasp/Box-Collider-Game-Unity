using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Update the camera's position
        transform.position = player.position + offset;

         transform.rotation = Quaternion.Euler(0, 0, 0); 
    }
}
