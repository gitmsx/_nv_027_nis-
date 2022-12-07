using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class nis : MonoBehaviour
{

    [SerializeField] private float _force;
    [SerializeField] private float _rotationSpeed = 10f;
     private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;


    
    private VadIS _VadIS;



    private void Awake()
    {
        _VadIS = new VadIS();
    }


    private void OnEnable()
    {
        _VadIS.Enable();

    }


    private void OnDisable()
    {
        _VadIS.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();
        _VadIS.Player.Shoot.performed += context => Short2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Short2()
    {
        print(Time.deltaTime);
        print("Time.deltaTime");

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
