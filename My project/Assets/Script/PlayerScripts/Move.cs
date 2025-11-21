using UnityEngine;
using UnityEngine.InputSystem;

namespace Script.PlayerScripts 
{
    public class Move : MonoBehaviour
    {
        private Rigidbody _rb;
        public Transform playerCamera;
        
        public float speed = 10f;
        public float jumpHeight = 2f;
        public float groundCheckDistance = 1.1f;  
        
        private float _horizontal;
        private float _vertical;
        private bool _isGrounded;
        
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.freezeRotation = true;
        }

        private void Update()
        {
            _isGrounded = Physics.Raycast(transform.position,Vector3.down, groundCheckDistance);
            
            MovePlayer();
        }
        
        void OnMove(InputValue movement)
        {
            // Получение оси движение взависимости от нажатой кнопки (WASD)
            Vector2 movementVector = movement.Get<Vector2>(); 
            _horizontal = movementVector.x;  
            _vertical = movementVector.y;    
        }

        void OnJump(InputValue jump)
        {
            if (_isGrounded)
            {
                _rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            }
        }

        private void MovePlayer()
        {
            Vector3 forward = playerCamera.forward;
            Vector3 right = playerCamera.right;
            
            forward.y = 0;
            right.y = 0;
            forward.Normalize();
            right.Normalize();

            Vector3 moveDirection = forward * _vertical + right * _horizontal;
            _rb.linearVelocity = new Vector3(moveDirection.x * speed, _rb.linearVelocity.y, moveDirection.z * speed);   
        }
    }
}