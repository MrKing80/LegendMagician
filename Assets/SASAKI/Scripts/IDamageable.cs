/// <summary>
/// ダメージを受ける処理を行うインターフェース
/// </summary>
public interface IDamageable
{
    /// <summary>
    /// ダメージを受ける処理
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage);
}
