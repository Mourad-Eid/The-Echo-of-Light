using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairCamera : MonoBehaviour
{
    Camera camera;
    Vector3 mousePostion;
    [SerializeField] GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        camera=GetComponent<Camera>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousePostion = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(mousePostion.x, mousePostion.y);
    }
}
