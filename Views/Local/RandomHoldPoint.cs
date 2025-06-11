using Kitchen;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ParentsEvent.Views.Local
{
    public class RandomHoldPoint : MonoBehaviour
    {
        public HoldPointContainer HoldPointContainer;
        public GameObject HoldPoints;
        private void Awake()
        {
            Change();
        }

        public void Change()
        {
            if (HoldPointContainer == null)
            {
                Mod.Logger.LogWarning("[RandomHoldPoint] HoldPointContainer is null");
                return;
            }
            if (HoldPoints == null)
            {
                Mod.Logger.LogWarning("[RandomHoldPoint] HoldPoints is null");
                return;
            }

            if (HoldPoints.transform.childCount <= 0)
            {
                Mod.Logger.LogWarning("[RandomHoldPoint] HoldPoints is empty");
                return;
            }

            if (HoldPointContainer.HoldPoint != null)
            {
                Mod.Logger.LogWarning("[RandomHoldPoint] HoldPoint is already empty");
                return;
            }
            
            HoldPointContainer.HoldPoint = HoldPoints.transform.GetChild(Random.Range(0, HoldPoints.transform.childCount));;
        }
    }
}