using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The camera's position is relative to the car's
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
