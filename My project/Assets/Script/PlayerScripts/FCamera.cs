using UnityEngine;
using UnityEngine.InputSystem;


namespace Script.PlayerScripts
{
    public class FCamera : MonoBehaviour
    {
        public bool optionSensitivity = true; 
        public bool cursorLock = true;
        
        public float mouseSensitivity = 30f;
        
        private float _xRotation;
        private float _yRotation;
        
        public Transform playerCamera;
        public Transform playerBody;
    
        void Start()
        {
            if (cursorLock)
            {
                Cursor.lockState = CursorLockMode.Locked;   
                Cursor.visible = true;
            }
        }
    
        void Update()
        {
            Vector2 look = Mouse.current.delta.ReadValue();

            float mouseX = look.x * mouseSensitivity * Time.deltaTime;
            float mouseY = look.y * mouseSensitivity * Time.deltaTime;
            
            playerBody.Rotate(Vector3.up * mouseX);
            
            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 32f);

            playerCamera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        }
    }
}
