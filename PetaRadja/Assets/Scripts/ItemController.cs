using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ItemController : MonoBehaviour
{
    public float allowDistance;
    public List<string> requireItems;
    public UnityEvent clickAction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if ( hit.collider.gameObject == gameObject)
                {
                    float distance = Vector3.Distance(PlayerController.instance.transform.position, hit.point);
                    if (distance <= allowDistance)
                    {
                        bool foundAllReqItems = true;
                        for ( int i=0; i<requireItems.Count; i++ )
                        {
                           if ( InventoryController.instance.ContainItem(requireItems[i]) == false )
                            {
                                foundAllReqItems = false;
                                break;
                            }
                        }
                        if (foundAllReqItems && !PlayerController.instance.IsLose() && !PlayerController.instance.IsWin() )
                            clickAction.Invoke();
                    }

                }
            }
        }

    }
}
