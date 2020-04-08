using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace player
{
    [RequireComponent(typeof(PlayerMover))]
    public class PlayerInput : MonoBehaviour
    {
        [Required]
        private PlayerMover _mover;

        private void Start()
        {
            _mover = GetComponent<PlayerMover>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _mover.MoveUp();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                _mover.MoveDown();
            }
        }
    }
}
