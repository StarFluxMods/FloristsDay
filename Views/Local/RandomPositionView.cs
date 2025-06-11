using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace ParentsEvent.Views.Local
{
    public class RandomPositionView : MonoBehaviour
    {
        public float minRotate;
        public float maxRotate;
        public float minPosition;
        public float maxPosition;
        public List<Transform> AffectedObjects = new List<Transform>();
        private void Awake()
        {
            Run();
        }

        public void Run()
        {
            if (AffectedObjects.Count == 0) return;
            foreach (Transform trans in AffectedObjects)
            {
                trans.rotation = Quaternion.Euler(0, Random.Range(minRotate, maxRotate), 0);
                trans.localPosition = new Vector3(Random.Range(minPosition, maxPosition), 0, Random.Range(minPosition, maxPosition));
            }
        }
    }
}