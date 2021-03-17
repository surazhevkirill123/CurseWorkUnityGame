using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bird : MonoBehaviour
{
	// Скорость перемещения
	public float speed = 2;
	
	// Flap force
	public float force = 300;
	
    // Start is called before the first frame update
    void Start()
    {
        // Летим в правую сторону
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Взлёт
		if (Input.GetKeyDown(KeyCode.Space))
			GetComponent<Rigidbody2D>().AddForce(Vector2.up*force);	
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.LoadLevel(0);

    }
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		// Перезапуск
		Application.LoadLevel(Application.loadedLevel);
	}
}
