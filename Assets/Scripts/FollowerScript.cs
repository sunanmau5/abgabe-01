using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerScript : MonoBehaviour
{
    [SerializeField]
    private Transform player = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination = source
        Vector3 directionToFace = player.position - transform.position;

        //access our current rotation = Quaternion Look Rotation
        transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}
