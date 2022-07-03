using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rg;
    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0f;
    public Camera theCamera;

    [SerializeField]
    private float lookSensitivity;
    // Start is called before the first frame update
   
   void Start(){
    rg = GetComponent<Rigidbody>();
   }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3  dir = new Vector3(h,0,v).normalized;
       transform.Translate(dir*moveSpeed*Time.deltaTime);
    }
}
