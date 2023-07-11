using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] internal float moveSpeed=0;
    internal static bool left = false;
    internal static bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);

        if(left && transform.position.x >= -1.5)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        else if (right && transform.position.x <= 1.5)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ello there mate");
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }
    }
}
