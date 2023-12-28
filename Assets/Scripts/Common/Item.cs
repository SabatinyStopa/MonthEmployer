using EmployerOfTheMonth.Enums;
using UnityEngine;

namespace EmployerOfTheMonth.Common
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private ItemKind kind;

        public ItemKind Kind { get => kind; set => kind = value; }

        public void OnDrawGizmosSelected()
        {
            var meshRenderer = GetComponent<Renderer>();

            if (meshRenderer == null) return;
            
            var bounds = meshRenderer.bounds;
            Gizmos.matrix = Matrix4x4.identity;
            Gizmos.color = Color.blue;
            Gizmos.DrawWireCube(bounds.center, bounds.extents * 2);
        }
    }
}