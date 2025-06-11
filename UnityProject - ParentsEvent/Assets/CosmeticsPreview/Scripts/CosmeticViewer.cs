using UnityEngine;

public class CosmeticViewer : MonoBehaviour
{
    public GameObject CosmeticContainer;
    public SkinnedMeshRenderer BoneSource;
    public bool ShouldRun;

    public void SetNewCosmetic(GameObject newCosmetic)
    {
        foreach (Transform child in CosmeticContainer.transform)
        {
            Destroy(child.gameObject);
        }
        
        GameObject cosmetic = Instantiate(newCosmetic, CosmeticContainer.transform, false);

        foreach (SkinnedMeshRenderer skinnedMeshRenderer in cosmetic.GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            skinnedMeshRenderer.bones = BoneSource.bones;
            skinnedMeshRenderer.updateWhenOffscreen = true;
        }

        if (ShouldRun)
        {
            foreach (Animator animator in gameObject.GetComponentsInChildren<Animator>())
            {
                animator.SetFloat("MovementSpeed", 1);
            }
        }
    }
}
