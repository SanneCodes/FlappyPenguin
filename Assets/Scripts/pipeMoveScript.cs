using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float deadZone = -100;
    public float speedPipe = 20;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Move Speed: " + speedPipe);
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * speedPipe) * Time.deltaTime;
    }
}
