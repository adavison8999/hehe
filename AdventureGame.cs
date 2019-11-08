using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textCompnent;
    // available now within inspector


    // Start is called before the first frame update
    void Start()
    {
      
        textCompnent.text = "Hello there sir";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
