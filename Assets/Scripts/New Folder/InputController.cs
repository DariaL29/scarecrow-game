
using UnityEngine;

public class InputController : MonoBehaviour
{

    public Vector3 mouseWorldPosition;
    public Vector3 laserStart = new Vector3(0,0,0);
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Camera.main.nearClipPlane)));

            mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));



            Debug.DrawLine(laserStart, mouseWorldPosition);
            Debug.Log(mouseWorldPosition);
        }




    }
}
