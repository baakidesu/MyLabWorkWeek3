using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int speed = 10;
    [SerializeField] GameObject helloText;

    void Start()
    {
        print("hello world");
        helloText.GetComponent<TextMeshPro>().text = "In the tall grass.";
        //transform.position = new Vector3(0, 0, 0); 
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime );
    }
}
