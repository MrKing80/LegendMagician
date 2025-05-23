using UnityEngine;

/// <summary>
/// 敵の移動処理を管理するクラス
/// 作成者：佐々木
/// </summary>
public class EnemyMove
{
    private GameObject _player = default;
    private float _moveSpeed = 0;

    public EnemyMove(float moveSpeed, GameObject player)
    {
        _moveSpeed = moveSpeed;
    }

    /// <summary>
    /// 敵の移動処理
    /// </summary>
    public void EnemyMoving()
    {
        //ここにプレイヤーの位置を常に見て追いかける処理を書きたい
    }
}
