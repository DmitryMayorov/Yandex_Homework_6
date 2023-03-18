using System.Collections;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public GameObject GoldBlock;

    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    [SerializeField] private HitEffect _hitEffectPrefab;
    [SerializeField] private Resources _resources;

    private int _coinsPerClick = 1;

    private float scale1;

    // Метод вызывается из Interaction при клике на объект
    public void Hit()
    {
        StartCoroutine(HitAnimation());
        Instantiate(GoldBlock, transform.position, Quaternion.identity);
    }

    // Анимация колебания куба
    private IEnumerator HitAnimation()
    {
        if (transform.localScale.x <= 1)
        {
            scale1 = transform.localScale.x;
        }
        for (float t = 0; t < 1f; t += Time.deltaTime / _scaleTime)
        {
            float scale2 = _scaleCurve.Evaluate(t);
            transform.localScale = Vector3.one * scale2 * scale1;
            yield return null;
        }
        transform.localScale = new Vector3(scale1, scale1, scale1);
    }

    // Этот метод увеличивает количество монет, получаемой при клике
    public void AddCoinsPerClick(int value)
    {
        _coinsPerClick += value;
    }
}
