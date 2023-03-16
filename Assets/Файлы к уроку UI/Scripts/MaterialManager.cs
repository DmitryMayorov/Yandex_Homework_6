using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    public void SetMaterial(Material material)
    {
        ModelVariants._currenSelected.GetComponent<Renderer>().material = material;
    }
}
