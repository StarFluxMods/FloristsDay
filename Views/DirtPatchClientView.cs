using Kitchen;
using UnityEngine;

namespace ParentsEvent.Views
{
    /*
     * This view is client side only, doesn't require a connection to ECS
     */
    public class DirtPatchClientView : MonoBehaviour
    {
        public GameObject[] HoldPoints;
        private GameObject HoldPoint => HoldPoints.Length > 0 ? HoldPoints[UnityEngine.Random.Range(0, HoldPoints.Length)] : null;
        private HoldPointContainer HoldPointContainer => GetComponent<HoldPointContainer>();

        private void Awake()
        {
            if (HoldPoint != null)
            {
                HoldPoint.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                if (HoldPointContainer != null)
                {
                    HoldPointContainer.HoldPoint = HoldPoint.transform;
                }
            }
        }
    }
}