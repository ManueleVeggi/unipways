using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // A)
    private Animator playerAnim; // B)
    public ParticleSystem explosionParticle; //B1) Smoke at collision
    public ParticleSystem dirtParticle;// C)

    public float jumpForce = 10; // A)
    public float gravityModifier; // A)

    public AudioClip jumpSound; // D) Sound effects
    public AudioClip crashSound;
    private AudioSource playerAudio;

    public bool isOnGround = true; 
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // A) Take rigid body for jump
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier; // A) Apply gravity to the jump

        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // A) Allow jump
            isOnGround = false;
     
            playerAnim.SetTrigger("Jump_trig"); // A) Apply animation for jump

            playerAudio.PlayOneShot(jumpSound, 0.5f);
            dirtParticle.Stop(); // C) // !! DOES NOT WORK
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground")) {
            if (!gameOver)
            {
                isOnGround = true;
                dirtParticle.Play(); //C) Dirt while running
            }
        } else if (collision.gameObject.CompareTag("Obstacle"))
        { 
            gameOver = true;

            playerAnim.SetBool("Death_b", true); // B) Apply animation for death
            playerAnim.SetInteger("DeathType_int", 1);

            explosionParticle.Play(); // B) Use collision against obstacles
            dirtParticle.Stop(); // !! DOES NOT WORK

            playerAudio.PlayOneShot(crashSound, 0.5f);

        } 
}
}
