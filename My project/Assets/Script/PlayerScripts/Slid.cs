using UnityEngine;
using UnityEngine.InputSystem;

namespace Script.PlayerScripts
{
    public class Sliding : MonoBehaviour
    {
        private Rigidbody _rb;
    
        public float maxSlideTime = 0.75f;
        public float slideForce = 200f;
        public float slideTimer = 0.5f;
    
        private float _horizontal;
        private float _vertical;

        public float slideYScale = 0.8f;
        public float startYScale = 1f;

        public bool sliding;
    
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void OnMove(InputValue movement)
        {
            Vector2 movementVector = movement.Get<Vector2>(); 
            _horizontal = movementVector.x;  
            _vertical = movementVector.y;    
        }

        private void FixedUpdate()
        {
            if (sliding)
            {
                SlidingMovement();
            }
        }

        void OnSlide()
        {
            sliding =  true;
        
            transform.localScale = new Vector3(transform.localScale.x, slideYScale, transform.localScale.z);

            slideTimer = maxSlideTime;
        }

        void SlidingMovement()
        {
            Vector3 inputDirection = transform.forward * _vertical +  transform.right * _horizontal;
        
            _rb.AddForce(inputDirection.normalized * slideForce, ForceMode.Force);
        
            slideTimer -= Time.deltaTime;

            if (slideTimer <= 0)
            {
                sliding = false;
                transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
            }
            
        }
    
    }
}
