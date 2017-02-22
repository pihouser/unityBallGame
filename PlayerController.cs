using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private int count;

    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start () {
        rb = GetComponent< Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
	}

        private void FixedUpdate()
    {
        //Physics Code here
        float moveHorizontal = Input.GetAxis("Horizontal"); // maps the keyboard movement to player
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winText.text = "You Win!";
        }
    }
         
}
