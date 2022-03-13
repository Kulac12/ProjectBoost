using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 100f; //itme gücü speed gibi
    [SerializeField] float rotationThrust = 1f;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        ProcessThrust();
        ProcessRotation();

    }

    void ProcessThrust()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime );   
           // Debug.Log("Press Space - Thrusting");
            audioSource.Play(); 
        }
        


    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationThrust);
           
        }
        else if (Input.GetKey(KeyCode.D))
        {

            ApplyRotation(-rotationThrust);
           // transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime);
            Debug.Log("Rotating Right");
        }
    }
    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; // manuel olarak döndðrmek için rotasyonu döndürdüðümüzü söylüyoruz.    
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // fizik sisteminin bir sorun olurda rotasyonu çözüyoruz
    }

}
