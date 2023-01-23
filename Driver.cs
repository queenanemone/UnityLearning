using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start() // callback
    {
        //play 버튼을 눌렀을 때 실행된다
    }

    // Update is called once per frame
    void Update()
    {
        //매 프레임마다 실행된다
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        transform.Rotate(0, 0, -1 * steerAmount);
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(0, moveAmount, 0);
    }
}
