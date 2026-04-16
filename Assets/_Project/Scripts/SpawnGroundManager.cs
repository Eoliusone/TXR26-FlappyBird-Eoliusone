using UnityEngine;

namespace _Project.Scripts
{
    public class SpawnGroundManager : MonoBehaviour
    {
        [SerializeField] private GameObject _groundPrefab;
        [SerializeField] private float _repeatRate = 8f;
        private GroundPool _groundPool;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _groundPool = GetComponent<GroundPool>();
        
            InvokeRepeating("SpawnGround", 2, _repeatRate);
        }

        private void SpawnGround()
        {
            Vector2 spawnPosition = new Vector2(12,-6);
            GameObject availableGround = _groundPool.GetFirstAvailableGround();
            availableGround.transform.position = spawnPosition;
            availableGround.SetActive(true);
        }

        public void StopSpawning()
        {
            CancelInvoke("SpawnGround");
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

