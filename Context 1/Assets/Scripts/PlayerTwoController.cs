using UnityEngine;
public class PlayerTwoController : MonoBehaviour
{
    private float playerSpeed2 = 5.0f;
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
   
        if (move != Vector3.zero)
        {
            Vector3 movePos = transform.position + move * Time.deltaTime * playerSpeed2;
            transform.position = movePos;
            gameObject.transform.forward = move;
        }
    }
}
