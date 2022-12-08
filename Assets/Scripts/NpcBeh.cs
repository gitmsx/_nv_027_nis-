using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class NpcBeh : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]    GameObject Signal;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Signal.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        Signal.SetActive(true);
        print(other.gameObject.tag);
        print("********************************* OnTriggerEnter ************************");
        print(inkJSON.text);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Signal.SetActive(true);
        print(collision.gameObject.tag);
        print("=============================== OnCollisionEnter");
    }


    private void OnTriggerExit(Collider other)
    {
        print(gameObject);
        Signal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    
        {

    }
}
