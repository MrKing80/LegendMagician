using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

/// <summary>
/// �f�[�^�x�[�X�A�N�Z�X�p�N���X
/// ����ҁF�ʈ�
/// </summary>
public class DataBaseManager : MonoBehaviour
{
    public static DataBaseManager Instance { get; private set; }

    private EnemyDataBase _enemyDataBase = default;
    private SkillDataBase _skillDataBase = default;

    private const string _enemyDataBaseName = "EnemyDataBase";
    private const string _skillDataBaseName = "SkillDataBase";

    private async void Awake()
    {
        // �V���O���g��������
        if (Instance == null)
        {
            Instance = this;
            // �V�[�����ׂ��ł��ݒ��ێ��ł���
            DontDestroyOnLoad(this.gameObject);

            // �f�[�^�x�[�X��񓯊��Ŏ擾
            _enemyDataBase = await LoadEnemyDataBase(_enemyDataBaseName);
            _skillDataBase = await LoadSkillDataBase(_skillDataBaseName);
        }
        else
        {
            // �����ȊO�̎����������ꍇ�A���������
            Destroy(this.gameObject);
        }
    }

    #region �G�l�~�[

    /// <summary>
    /// �G�l�~�[�f�[�^�x�[�X��񓯊��Ń��[�h
    /// </summary>
    /// <param name="address">�f�[�^�x�[�X��</param>
    /// <returns></returns>
    private async Task<EnemyDataBase> LoadEnemyDataBase(string address)
    {
        // �G�l�~�[�f�[�^�̃X�N���v�^�u���I�u�W�F�N�g���AAddressables����ǂݍ��� 
        _enemyDataBase = await Addressables.LoadAssetAsync<EnemyDataBase>(address).Task;

        // �G�l�~�[�f�[�^�����[�h�o������A�G�l�~�[�f�[�^��Ԃ�
        if(_enemyDataBase != null)
        {
            return _enemyDataBase;
        }

        Debug.LogError("�G�l�~�[�f�[�^�x�[�X�����[�h�ł��܂���I");
        return null;
    }

    /// <summary>
    /// �G�l�~�[�f�[�^�̏���Ԃ�
    /// </summary>
    /// <param name="id">�f�[�^�x�[�X���ł�ID</param>
    /// <returns>�w�肵���G�l�~�[�f�[�^��Ԃ�</returns>
    public EnemyData GetEnemyData(int id)
    {
        return _enemyDataBase._enemyDatas[id];
    }

    #endregion

    #region �X�L��

    /// <summary>
    /// �X�L���f�[�^�x�[�X��񓯊��Ń��[�h
    /// </summary>
    /// <param name="address">�f�[�^�x�[�X��</param>
    /// <returns></returns>
    private async Task<SkillDataBase> LoadSkillDataBase(string address)
    {
        // �X�L���f�[�^�̃X�N���v�^�u���I�u�W�F�N�g���AAddressables����ǂݍ���
        _skillDataBase = await Addressables.LoadAssetAsync<SkillDataBase>(address).Task;

        // �X�L���f�[�^�����[�h�o������A�X�L���f�[�^��Ԃ�
        if (_skillDataBase != null)
        {
            return _skillDataBase;
        }

        Debug.LogError("�X�L���f�[�^�x�[�X�����[�h�ł��܂���I");
        return null;
    }

    /// <summary>
    /// �X�L���f�[�^�̏���Ԃ�
    /// </summary>
    /// <param name="id">�f�[�^�x�[�X���ł�ID</param>
    /// <returns>�w�肵���X�L���f�[�^��Ԃ�</returns>
    public SkillData GetSkillData(int id)
    {
        return _skillDataBase._skillDatas[id];
    }

    #endregion
}
