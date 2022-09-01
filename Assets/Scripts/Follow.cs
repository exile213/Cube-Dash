
using UnityEngine;

public class Follow : MonoBehaviour
{ 
    public Transform player;

    public Vector3 offset;
    //Vector3 stores 3 float numbers
    void Update()
    {
        transform.position = player.position + offset;


    }
}
