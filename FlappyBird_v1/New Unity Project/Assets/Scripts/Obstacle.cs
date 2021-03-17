using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	// Скорость движения (0 - без движения)
	public float speed = 0;
	
	// Переключение направления движения каждые х секунд
	public float switchTime = 2;
	
    // Start is called before the first frame update
    void Start()
    {
        // Направления первоначального движения
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
	
		// Переключение через каждые несколько секунд
		InvokeRepeating("Switch", 0, switchTime);
    }

    
    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
