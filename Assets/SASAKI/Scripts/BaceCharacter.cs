using UnityEngine;

/// <summary>
/// キャラクターのベースクラス
/// 作成者：佐々木
/// </summary>
public abstract class BaceCharacter : MonoBehaviour
{
    protected string _characterName = "";
    protected int _hp = 0;
    protected float _attackPower = 0f;
    protected float _attackSpeed = 0f;
    protected float _moveSpeed = 0f;
    private int _characterId = 0;
    protected bool _isAlive = true;
    // TODO : 後で属性の情報を格納する変数を書き足す

    public BaceCharacter(string playerName, int hp, float attackPower, float attackSpeed, float moveSpeed)
    {
        _characterName = playerName;
        _hp = hp;
        _attackPower = attackPower;
        _attackSpeed = attackSpeed;
        _moveSpeed = moveSpeed;
    }

    /// <summary>
    /// 生存判定用メソッド
    /// ※ abstractは継承したら絶対このメソッドを使ってねという意味になるよ
    /// </summary>
    /// <returns>true：生きてる false：死んでる</returns>
    public abstract bool IsAlive();
}
