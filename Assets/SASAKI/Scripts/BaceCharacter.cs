using System.Net.NetworkInformation;
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
    protected bool _isAlive = true;
    //後で属性の情報を格納する変数を書き足す

    private void Start()
    {
        print("炎魔法を呼び出します");
        PlayerClass playerClass = new PlayerClass();
        FireAttack fireAttack = new FireAttack();
    }

    /// <summary>
    /// 生存判定用メソッド
    /// abstractは継承したら絶対このメソッドを使ってねという意味になるよ
    /// </summary>
    /// <returns>true：生きてる false：死んでる</returns>
    public abstract bool IsAlive();
}
