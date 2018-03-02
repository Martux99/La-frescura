using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    public Transform Position;
    public Rigidbody2D rb2d;
    private int screen;
    public float speed = 50f;
    float spd = 0;
    int buleano = 0;
    private Vector2 distance;
    private GameObject movetoesto;
    public Transform Target;
    public Vector3 Camara;
    void Start()
    {
        movetoesto = GameObject.FindGameObjectWithTag("Esto");
    }
    void FixedUpdate()
    {
        //Camara = Camera.main.ScreenToViewportPoint(Input.GetTouch(0).position);
        Touch touch = Input.GetTouch(0);
        distance = touch.position;
        if (movetoesto != null)
        {
            spd = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, distance, spd);
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, 5f, 5f), Mathf.Clamp(transform.position.y, 5f, 5f));
        }


    }
}
