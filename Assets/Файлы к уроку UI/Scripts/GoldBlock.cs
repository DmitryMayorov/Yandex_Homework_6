using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBlock : MonoBehaviour
{
    [SerializeField] private Resources _resources;

    [SerializeField] private HitEffect _hitEffectPrefab;

    private int _randomForceX = 0;

    private int _ForceY = 6;

    private int _randomForceZ = 0;

    private int _coinsPerClick = 1;

    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        _resources = GameObject.Find("Resources").gameObject.GetComponent<Resources>();

        _randomForceX = Random.Range(-2, 2);

        _randomForceZ = Random.Range(-2, 2);

        rigidbody.AddForce(new Vector3(_randomForceX , _ForceY, _randomForceZ), ForceMode.Impulse);
    }

    public void Hit()
    {
        HitEffect hitEffect = Instantiate(_hitEffectPrefab, transform.position, Quaternion.identity);
        hitEffect.Init(_coinsPerClick);
        _resources.CollectCoins(1, transform.position);
        Destroy(gameObject);
    }
}
