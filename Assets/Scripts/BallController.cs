using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    [SerializeField] private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomPlace();
        SetRandomVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetRandomPlace()
    {
        transform.position = new Vector3(0f, Random.Range(-4, 4), 0f);
    }

    private void SetRandomVelocity()
    {
        float velX = Random.Range(0.5f, 1f);
        Debug.Log(velX);
        float velY = math.sqrt(1 - velX * velX);
        Vector3 vel = new Vector3(velX, velY, 0f);
        Debug.Log(vel);
        GetComponent<Rigidbody2D>().velocity = velocity * vel;
    }
}
