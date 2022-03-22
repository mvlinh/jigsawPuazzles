using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomObject : MonoBehaviour
{
    [SerializeField] Object[] Box;

    private int rand;
    void Start()
    {
        rand = Random.Range(0, Box.Length);
        Instantiate(Box[rand],this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
