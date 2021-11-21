using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private PaddleConfig config;

    private static Vector3 _direction;

    [SerializeField] private float movementAmount;
    // Start is called before the first frame update
    void Start()
    {
        _direction = new Vector3(  movementAmount,0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && config.direction*transform.position[1]<4)
            transform.Translate(_direction * Time.deltaTime * config.direction);
        if (Input.GetKey(KeyCode.DownArrow) && config.direction*transform.position[1]>-4)
            transform.Translate(-_direction * Time.deltaTime * config.direction);
    }
}
