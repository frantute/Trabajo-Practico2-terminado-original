using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    Vector3 nombrecheckpoint;

    //public int maxJumps;

    bool hasJump = true;
    Rigidbody rb;
    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        //hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
            PlayClip();
        }
        if (transform.position.y <= -5)
        {
            SceneManager.LoadScene("Cartel_De_Perdiste");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Piso")
        {
            hasJump = true;

        }
        if (other.gameObject.name == "Piso2")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Piso3")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Plataforma1")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Plataforma2")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Plataforma3")
        {
            hasJump = true;
        }
        if(other.gameObject.name == "Cubito")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito1")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito2")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito3")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito4")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito5")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Cubito6")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Piso4")
        {
            hasJump = true;
        }
        if (other.gameObject.name == "Piso5")
        {
            hasJump = true;
        }
        
        
    }
    void PlayClip()
        {
            source.clip = clip;
            source.Play();
        }
}
