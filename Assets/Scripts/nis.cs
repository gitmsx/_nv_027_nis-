using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class nis : MonoBehaviour
{

    [SerializeField] private float _force;
    [SerializeField] private float _rotationSpeed = 10f;
     private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxisRaw("Mouse X");
        Vector3 force = new Vector3(h, 0f, v) * _force;
        _rigidbody.AddRelativeForce(force);

        transform.Rotate(0f, r * _rotationSpeed, 0f);
    }

}
