using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BALL : MonoBehaviour
{
    public Text ScoreRightText;
    public Text ScoreLeftText;
    public int ScoreLeft;
    public int ScoreRight;
    public float speed = 30;
    float hitFactor(Vector2 ballPosition, Vector2 racketPosision, float racketHeight)
    {
        return (ballPosition.y - racketPosision.y) / racketHeight;
    }
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player 1")
        {
            float y = hitFactor(transform.position,
                     collision.transform.position,
                     collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
       if(collision.gameObject.name == "player 2")
        {
            float y = hitFactor(transform.position,
                     collision.transform.position,
                     collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
       if (collision.gameObject.name =="Ysar")
        {
            ScoreRight ++;
            ScoreRightText.text = ScoreRight.ToString();

        }
        if ( collision.gameObject.name=="ymin")
        {
            ScoreLeft ++;
            ScoreLeftText.text = ScoreLeft.ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
