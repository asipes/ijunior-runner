using Sirenix.OdinInspector;
using UnityEngine;
using static UnityEngine.Color;

namespace player
{
    public class Player : MonoBehaviour
    {
        [GUIColor("@Color.Lerp(Color.green, Color.white, Mathf.Sin((float)EditorApplication.timeSinceStartup))")]
        [SerializeField] private int _health;

        [GUIColor(1f,0.8f,0.5f)]
        [Button("Damage")]
        public void ApplyDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
        
        }
    }
}
