using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 30;
    public string Axis;
    private void FixedUpdate()

    {
        float v = Input.GetAxisRaw(Axis) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
