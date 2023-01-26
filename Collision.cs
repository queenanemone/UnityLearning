using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    int packageNumber = 0;
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //부딛힘을 감지했을 때, Console에 출력
        Debug.Log("Crash!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //트리거를 감지했을 때, Console에 출력력
        if (other.tag == "Package" && packageNumber == 0){
            packageNumber++;
            Debug.Log("Package picked up");
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer"){
            if (packageNumber == 0){
                Debug.Log("You don't have any package to deliver.");
            }
            else {
                packageNumber--;
                spriteRenderer.color = noPackageColor;
                Debug.Log("Package delivered");
            }
        }
    }
}
