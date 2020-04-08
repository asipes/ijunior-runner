using System;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEngine;

namespace player
{
    public class PlayerMover : MonoBehaviour
    {
        [Title("Speed")]
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _stepSize;
        
        [Title("Height")]
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _minHeight;

        private Vector3 _targetPosition;

        private void Start()
        {
            _targetPosition = transform.position;
        }

        private void Update()
        {
            if (transform.position != _targetPosition)
            {
                transform.position =
                    Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
            }
        }

        public void MoveUp()
        {
            if (_targetPosition.y < _maxHeight)
            {
                SetNextPosition(_stepSize);
            }
        }

        public void MoveDown()
        {
            if (_targetPosition.y > _minHeight)
            {
                SetNextPosition(-_stepSize);
            }
        }

        private void SetNextPosition(float stepSize)
        {
            _targetPosition = new Vector3(_targetPosition.x, _targetPosition.y + stepSize);
        }
    }
}
