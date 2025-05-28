using UnityEngine;

public class EnemyTargetLasers : MonoBehaviour
{
    public Transform laserShotPosition;
    public float _speed = 1f;
    public ParticleSystem startWavePS;
    public ParticleSystem startParticles;
    public int startParticlesCount = 100;
    public GameObject laserShotPrefab;

    private PlayerController _playerController = default;
    private Vector3 _enemyPosition;

    private Vector3 _worldPosition;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startWavePS.Emit(1);
            startParticles.Emit(startParticlesCount);
        }

        anim.SetBool("Fire", Input.GetMouseButton(0));

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("Fire", true);
            startWavePS.Emit(1);
            startParticles.Emit(startParticlesCount);
            Instantiate(laserShotPrefab, laserShotPosition.position, transform.rotation);
        }
    }
    void FixedUpdate()
    {
        _worldPosition = _playerController.GetEnemy();

        Quaternion toRotation = Quaternion.LookRotation(_worldPosition - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, _speed * Time.deltaTime);
        _enemyPosition = _worldPosition;

    }
}
