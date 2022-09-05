using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace simulasi.inputRay
{
    public class InputRaycast : MonoBehaviour
    {
        [SerializeField]
        private LayerMask ss;
        [SerializeField]
        private Camera main;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                 Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Ray ray = main.ScreenPointToRay(Input.mousePosition);
                //Ray sa = main.ScreenToWorldPoint(Input.mousePosition);

                /*if (Physics.Raycast(ray, out RaycastHit hitInfo, float.MaxValue, ss))
                {
                    Debug.Log("masuh");
                    IClicked klik = hitInfo.collider.GetComponent<IClicked>();
                    if (klik != null)
                        klik.Name(hitInfo.collider.name);

                }


                if (Physics2D.Raycast(pos, Vector2.zero))
                {
                    Debug.Log("masuh");
                    IClicked klik = hitInfo.collider.GetComponent<IClicked>();
                    if (klik != null)
                        klik.Name(hitInfo.collider.name);

                }
                */

                RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

                if (hit.collider != null)
                {
                    Debug.Log("masuh");
                    IClicked klik = hit.collider.GetComponent<IClicked>();
                    if (klik != null)
                    {
                        Debug.Log(hit.collider.name);
                        klik.Name(hit.collider.name);
                    }
                }


                //Debug.Log(ray);
            }
        }
    }
}