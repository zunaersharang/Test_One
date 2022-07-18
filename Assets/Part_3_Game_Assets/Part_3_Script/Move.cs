using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _yVelocity = 0;
    private float _xVelocity = 0;

    public float moveStat = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _yVelocity = moveStat;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _yVelocity = -moveStat;
        }
        else
        {
            _yVelocity = 0;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _xVelocity = -moveStat;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _xVelocity = moveStat;
        }
        else
        {
            _xVelocity = 0;
        }

        _rigidbody.velocity = new Vector3(_xVelocity, _yVelocity, 0);
    }
}