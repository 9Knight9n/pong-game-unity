using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    [SerializeField] private float velocity;

    private Rigidbody2D _rigidbody2D;

    private Vector3 _lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        SetRandomPlace();
        SetRandomVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        _lastVelocity = _rigidbody2D.velocity;
    }

    private void SetRandomPlace()
    {
        transform.position = new Vector3(0f, Random.Range(-4, 4), 0f);
    }

    private void SetRandomVelocity()
    {
        float velX = Random.Range(0.7f, 1f)*Random.Range(-1f, -0.7f);
        Debug.Log(velX);
        float velY = math.sqrt(1 - velX * velX);
        velY = Random.Range(-1f, 1f) > 0 ? velY : -velY;
        Vector3 vel = new Vector3(velX, velY, 0f);
        GetComponent<Rigidbody2D>().velocity = velocity * vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(Tags.Wall.ToString()) || other.gameObject.CompareTag(Tags.Paddle.ToString()))
        {
            var speed = _lastVelocity.magnitude;
            var direction = Vector3.Reflect(_lastVelocity.normalized, other.contacts[0].normal);
            _rigidbody2D.velocity = direction * Mathf.Max(speed,0f);
        }
    }
    
}
