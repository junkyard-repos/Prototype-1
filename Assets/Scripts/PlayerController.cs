using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float speed = 20f;
  public float zInput;
  public float xInput;
  public float turnSpeed;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    xInput = Input.GetAxis("Horizontal");
    zInput = Input.GetAxis("Vertical");

    transform.Translate(Vector3.forward * Time.deltaTime * speed * zInput);
    if (zInput != 0)
    {
      transform.Rotate(Vector3.up * turnSpeed * xInput * Time.deltaTime);
    }
    // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * xInput);
  }
}
