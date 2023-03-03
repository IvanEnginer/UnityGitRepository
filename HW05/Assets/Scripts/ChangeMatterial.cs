using UnityEngine;

public class ChangeMatterial : MonoBehaviour
{
    public Renderer Renderer;

    public void SetMaterial(Material material)
    {
        Renderer.material = material;
    }
}
