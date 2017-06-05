using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopta : MonoBehaviour {

    private Rigidbody2D rb;
    public GameObject prvi;
    public GameObject drugi;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        prvi = GameObject.Find("sarajevo");
        drugi = GameObject.Find("zeljo");
        Rez.canAdd = true;
        StartCoroutine(Pause());
	}
	
	// Update is called once per frame
	void Update () {
      if(this.transform.position.x >= 6.5f)
        {
            Rez.canAdd = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
        if (this.transform.position.x <= -6.5f)
        {
            Rez.canAdd = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if (directionX == 0)
        {
            directionX = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector2(9f*directionX,9f*directionY);
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.name == "sarajevo")
        {
            if (prvi.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(10f,10f);
            }
            else if (prvi.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(10f, -10f);
            }

            else
            {
                rb.velocity = new Vector2(10f, 0f);
            }
        }
        if (hit.gameObject.name == "zeljo")
        {
            if (drugi.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-10f, 10f);
            }
            else if (drugi.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-10f, -10f);
            }
            else
            {
                rb.velocity = new Vector2(-10f, 0f);
            }

        }
    }
}
