using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;

    private void Awake()
    {
        _direction = Vector3.zero;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            _direction.z = 1f;
        else if (Input.GetKey(KeyCode.S))
            _direction.z = -1f;
        else
            _direction.z = 0f;

        if (Input.GetKey(KeyCode.D))
            _direction.x = 1f;
        else if (Input.GetKey(KeyCode.A))
            _direction.x = -1f;
        else
            _direction.x = 0f;

    }

    private void FixeUpdate()
    {
        transform.Translate(_direction * _speed * Time.fixedDeltaTime);

    }
}
