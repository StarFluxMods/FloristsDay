using System;
using System.Collections.Generic;
using UnityEngine;

namespace New_folder.Scripts
{
    public class CustomerHolder : MonoBehaviour
    {
        public GameObject Cosmetic;
        public List<CosmeticViewer> CosmeticViewerList;

        private void Start()
        {
            if (Cosmetic == null) return;
            foreach (CosmeticViewer cosmeticViewer in CosmeticViewerList)
            {
                cosmeticViewer.SetNewCosmetic(Cosmetic);
            }
        }
    }
}