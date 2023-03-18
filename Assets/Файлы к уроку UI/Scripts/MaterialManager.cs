using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public Material _material;

    public void SetMaterial(Material material)
    {
        _material = material;

        ModelVariants._currenSelected.GetComponent<Renderer>().material = material;
    }
}
