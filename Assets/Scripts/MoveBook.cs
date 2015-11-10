using UnityEngine;
using System.Collections;

public class MoveBook : MonoBehaviour
{
    Camera camera;
    public Transform scanPos;
    private Vector3 offset;
    private Vector3 screenPoint;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(scanPos.position);

        offset = scanPos.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }


    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }
}


