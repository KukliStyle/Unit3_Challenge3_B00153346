using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController PlayerControllerScript;

    void Start()
    {
        PlayerControllerScript = 
        GameObject.Find("Player").GetComponent<PlayerController>();

    }

    void Update()
    {  if (PlayerControllerScript.gameOver == false){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
      }
    }
}
