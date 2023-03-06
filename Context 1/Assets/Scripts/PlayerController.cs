using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 5.0f;
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (move != Vector3.zero)
        {
            Vector3 movePos = transform.position + move * Time.deltaTime * playerSpeed;
            transform.position = movePos;
            gameObject.transform.forward = move;
        }
        
    }
}
