using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 moveDirection;
    public float speed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z -= 1;
        }

        moveDirection *= Time.deltaTime * speed;

        characterController.Move(moveDirection);
    }
}
