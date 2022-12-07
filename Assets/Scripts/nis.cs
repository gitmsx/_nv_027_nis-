using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class nis : MonoBehaviour
{

    [SerializeField] private float _force;
    [SerializeField] private float _rotationSpeed = 10f;
     private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;



    [HideInInspector] private Text Text__info003;
    [HideInInspector] private Text Text__info001;
    [HideInInspector] private Text Text__info002;

    




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

        Text__info001 = GameObject.Find("Text__info001").GetComponent<Text>();
        Text__info002 = GameObject.Find("Text__info002").GetComponent<Text>();
        Text__info003 = GameObject.Find("Text__info003").GetComponent<Text>();
        Text__info003.text = "Text__info003";


    }

    // Update is called once per frame
    void Update()
    {

        Vector2 vec2 = _VadIS.Player.Move.ReadValue<Vector2>();
        Vector3 force2 = new Vector3(vec2.x, 0f, vec2.y) * _force*100;
        _rigidbody.AddRelativeForce(force2);

        Text__info003.text = force2.ToString();
        Text__info001.text = vec2.x.ToString();
        Text__info002.text = vec2.y.ToString();

    }


    void Short2()
    {
        print(Time.deltaTime);
        print("Time.deltaTime");

    }


    void FixedUpdate2()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxisRaw("Mouse X");
        Vector3 force = new Vector3(h, 0f, v) * _force;
        _rigidbody.AddRelativeForce(force);

        transform.Rotate(0f, r * _rotationSpeed, 0f);
    }

}
