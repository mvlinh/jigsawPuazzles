using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    private void Update()
    {
        Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.right, Color.red);
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit && hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
   
}
