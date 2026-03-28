using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input : MonoBehaviour
{
    //este script sirve para controlar las esferas en las escenas y comprobar las físicas del motor
    //todas las esferas de este proyecto tienen el mismo script

    //player input y rigidbody para obtener los datos del movimiento
    PlayerInput playerInput;
    Rigidbody rb;

    //vector2 para almacenar movimiento y un int con velocidad (de movimiento)
    Vector2 movement;
    int speed = 5;
    
    void Start()
    {
        //obtenemos los componentes
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //leemos el valor del movimiento cada frame
        movement = playerInput.actions["Move"].ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        //movemos el rigidbody con el valor del movimiento, multiplicado por la velocidad y el tiempo entre frames
        rb.MovePosition(rb.position + new Vector3(-movement.x, 0, -movement.y) * speed * Time.fixedDeltaTime);
    }
}
