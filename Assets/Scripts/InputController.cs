using UnityEngine;
using System.Collections;


namespace Runner
{


    public class InputController : MonoBehaviour
    {

        private MovementScript _movementController;
        private bool _jump;

        private void Awake()
        {
            _movementController = GetComponent<MovementScript>();
        }

        private void Update()
        {
            if (!_jump)
                _jump = Input.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            _movementController.Move(1, _jump);
            _jump = false;
        }
    }
}
