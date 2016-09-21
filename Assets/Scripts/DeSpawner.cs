using UnityEngine;
using System.Collections;

namespace Runner
{

    public class DeSpawner : MonoBehaviour
    {

        // sami.kojo@tamk.fi

        [SerializeField] private SpawnerController _spawnerController;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_spawnerController == null || !_spawnerController.AddToPool(other.gameObject))
            {
                Destroy(other.gameObject);
            }

        }
    }
}
