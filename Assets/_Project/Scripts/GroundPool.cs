using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    public class GroundPool : MonoBehaviour
    {
        [SerializeField] private GameObject _groundPrefab;
        [SerializeField] private int _poolCapacity = 10;

        private List<GameObject> _list = new List<GameObject>();

        void Start()
        {
            for (int i = 0; i < _poolCapacity; i++)
            {
                GameObject ground = Instantiate(_groundPrefab, transform);
                ground.name = "Ground" + i;
                ground.SetActive(false);
                _list.Add(ground);
            }
        }

        public GameObject GetFirstAvailableGround()
        {
            foreach (GameObject ground in _list)
            {
                if (ground.activeSelf == false) return ground;
            }

            GameObject newGround = Instantiate(_groundPrefab, transform);
            newGround.SetActive(false);
            _list.Add(newGround);
            return newGround;
        } 
    }
}
