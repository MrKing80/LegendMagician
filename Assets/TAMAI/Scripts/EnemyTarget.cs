using System.Collections;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float _speed = 1f;
    public ParticleSystem _startWavePS;
    public ParticleSystem _startParticles;
    public ParticleSystem _smallMissiles;
    public int _smallMissilesCount = 100;
    public ParticleSystem _bigMissileOne;
    public ParticleSystem _bigMissileTwo;
    public ParticleSystem _bigMissileThree;
    public int _bigMissileThreeCount = 6;

    private PlayerController _playerController = default;
    private Vector3 _enemyPosition;

    private Vector3 _worldPosition;
    private Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _startWavePS.Emit(1);
            _startParticles.Emit(_smallMissilesCount);
        }

        if (Input.GetMouseButton(0))
        {
            var em = _smallMissiles.emission;
            em.enabled = true;
            _anim.SetBool("Fire", true);
        }
        else
        {
            var em = _smallMissiles.emission;
            em.enabled = false;
            _anim.SetBool("Fire", false);
        }

        if (Input.GetMouseButtonDown(1))
        {
            _anim.SetBool("Fire", true);
            _bigMissileOne.Emit(1);
            if (_bigMissileTwo)
            {
                _bigMissileTwo.Emit(1);
            }
            if (_bigMissileThree)
            {
                _bigMissileThree.Emit(_bigMissileThreeCount);
            }
            _startWavePS.Emit(1);
            _startParticles.Emit(_smallMissilesCount);
        }
    }
    void FixedUpdate()
    {
        _worldPosition = _playerController.GetEnemy();

        Quaternion toRotation = Quaternion.LookRotation(_worldPosition - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, _speed * Time.deltaTime);
        _enemyPosition = _worldPosition;

    }
    private IEnumerator NearestEnemy()
    {            
        // Žw’èŽžŠÔ‘Ò‹@ 
        yield return new WaitForSeconds(1);
    }
}
