using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public float mousesen = 100f;
    void Start()
    {

        transform.position = player.position;
        transform.rotation = player.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.position;
        transform.rotation = player.rotation;
    }
}