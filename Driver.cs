using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    // Start is called before the first frame update
    void Start() // callback
    {
        //play 버튼을 눌렀을 때 실행된다
    }

    // Update is called once per frame
    void Update()
    {
        //매 프레임마다 실행된다
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -1 * steerAmount);
        transform.Translate(0, moveAmount, 0);
        //Time.deltaTime : 각 프레임이 실행되는 데 걸리는 시간
        //빠른 컴퓨터 = 각 프레임마다 짧은 시간이 걸림, 느린 컴퓨터 = 각 프레임마다 긴 시간이 걸림
        //각 프레임에 소요된 시간에 어떠한 값을 곱하면, 프레임률 독립성이라는 값을 구함. 
        //프레임율 독립성 : 게임이 컴퓨터의 속도에 상관없이 결과물이 동일한 동작으로 만들기 위해 계산

    }
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "SpeedUp"){
            moveSpeed = boostSpeed;
        }
    }
}