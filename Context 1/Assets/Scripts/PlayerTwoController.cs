using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller2;
    private Vector3 playerVelocity2;
    private bool groundedPlayer2;
    private float playerSpeed2 = 4.0f;
    private float jumpHeight2 = 1.0f;
    private float gravityValue2 = -9.81f;

    private void Awake()
    {
        controller2 = GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer2 = controller2.isGrounded;
        if (groundedPlayer2 && playerVelocity2.y < 0)
        {
            playerVelocity2.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
        controller2.Move(move * Time.deltaTime * playerSpeed2);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer2)
        {
            playerVelocity2.y += Mathf.Sqrt(jumpHeight2 * -3.0f * gravityValue2);
        }

        playerVelocity2.y += gravityValue2 * Time.deltaTime;
        controller2.Move(playerVelocity2 * Time.deltaTime);
    }
}
