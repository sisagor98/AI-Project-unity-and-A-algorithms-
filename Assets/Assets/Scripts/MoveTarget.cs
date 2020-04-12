using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{

    public GameObject btn;

    public LayerMask hitLayers;

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
            {
                if (hit.collider.CompareTag("Ground"))
                    this.transform.position = hit.point + Vector3.one * .5f;
            }
        }
    }


   /* void Play()
    {
        btn.SetActive
    }*/
}

