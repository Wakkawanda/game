using UnityEngine;
using UnityEngine.InputSystem;

namespace Script
{
    public class Test : MonoBehaviour
    {
        private Game _g;
        
        private void Start()
        {
            Start st = new Start();
            
            st.NewGame();
        }

        void OnMove(InputValue movement)
        {
            
            
        }
    }
}