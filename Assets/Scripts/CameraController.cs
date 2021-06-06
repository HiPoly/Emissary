using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Enables intro camera movement;
    public bool introAnim;

    public GameObject currentFocus;
    public GameObject player;
    public float panSpeed = 1.0f;
    public float panBorderThickness = 10f;
    //set pan limits to be relative to the player location later
    public float panLimitX = 20000f;
    public float panLimitY = 20000f;
    public float scrollSpeed = 1.0f;
    private float minY = 1f;
    private float maxY = 5f;


    private void Start()
    {
        //set initial focus to the player
        currentFocus = player;
        if (introAnim)
        {
            //Do a swoosh when the game starts
        }
    }

    void Update()
    {
        Vector3 pos = this.transform.position;
        //60 Deg Rotations (Add Lerp)
        if (Input.GetKeyDown(KeyCode.Q)){
            transform.RotateAround(currentFocus.transform.position, Vector3.up, 60);
        }
        else if (Input.GetKeyDown(KeyCode.E)){
            transform.RotateAround(currentFocus.transform.position, Vector3.up, -60);
        }
        //Panning
        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - panBorderThickness){
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= panBorderThickness){
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= panBorderThickness){
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - panBorderThickness){
            pos.x += panSpeed * Time.deltaTime;
        }
        //ScrollforZoom/Rotate
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollSpeed * Time.deltaTime;
        //PanClamps
        //pos.x = Mathf.Clamp(pos.x, -panLimitX, panLimitX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        //pos.z = Mathf.Clamp(pos.z, -panLimitY, panLimitY);

        //update position from inputs
        transform.position = pos;


        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //var hit : RaycastHit;
        if (Physics.Raycast(ray, hit))
        {
            if (hit.collider.tag == "clickableCube"{
                //hit.collider.gameObject now refers to the 
                //cube under the mouse cursor if present
            }
        }


    }
}
