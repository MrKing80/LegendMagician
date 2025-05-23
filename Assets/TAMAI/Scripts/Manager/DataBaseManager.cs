using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

/// <summary>
/// データベースアクセス用クラス
/// 制作者：玉井
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
        // シングルトン化する
        if (Instance == null)
        {
            Instance = this;
            // シーンを跨いでも設定を保持できる
            DontDestroyOnLoad(this.gameObject);

            // データベースを非同期で取得
            _enemyDataBase = await LoadEnemyDataBase(_enemyDataBaseName);
            _skillDataBase = await LoadSkillDataBase(_skillDataBaseName);
        }
        else
        {
            // 自分以外の自分がいた場合、自らを消す
            Destroy(this.gameObject);
        }
    }

    #region エネミー

    /// <summary>
    /// エネミーデータベースを非同期でロード
    /// </summary>
    /// <param name="address">データベース名</param>
    /// <returns></returns>
    private async Task<EnemyDataBase> LoadEnemyDataBase(string address)
    {
        // エネミーデータのスクリプタブルオブジェクトを、Addressablesから読み込む 
        _enemyDataBase = await Addressables.LoadAssetAsync<EnemyDataBase>(address).Task;

        // エネミーデータをロード出来たら、エネミーデータを返す
        if(_enemyDataBase != null)
        {
            return _enemyDataBase;
        }

        Debug.LogError("エネミーデータベースをロードできません！");
        return null;
    }

    /// <summary>
    /// エネミーデータの情報を返す
    /// </summary>
    /// <param name="id">データベース内でのID</param>
    /// <returns>指定したエネミーデータを返す</returns>
    public EnemyData GetEnemyData(int id)
    {
        return _enemyDataBase._enemyDatas[id];
    }

    #endregion

    #region スキル

    /// <summary>
    /// スキルデータベースを非同期でロード
    /// </summary>
    /// <param name="address">データベース名</param>
    /// <returns></returns>
    private async Task<SkillDataBase> LoadSkillDataBase(string address)
    {
        // スキルデータのスクリプタブルオブジェクトを、Addressablesから読み込む
        _skillDataBase = await Addressables.LoadAssetAsync<SkillDataBase>(address).Task;

        // スキルデータをロード出来たら、スキルデータを返す
        if (_skillDataBase != null)
        {
            return _skillDataBase;
        }

        Debug.LogError("スキルデータベースをロードできません！");
        return null;
    }

    /// <summary>
    /// スキルデータの情報を返す
    /// </summary>
    /// <param name="id">データベース内でのID</param>
    /// <returns>指定したスキルデータを返す</returns>
    public SkillData GetSkillData(int id)
    {
        return _skillDataBase._skillDatas[id];
    }

    #endregion
}
