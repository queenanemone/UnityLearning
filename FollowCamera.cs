using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    [SerializeField] Vector3 newVector;
    void Update()
    {
        transform.position = thingToFollow.transform.position + newVector;
    }
}
