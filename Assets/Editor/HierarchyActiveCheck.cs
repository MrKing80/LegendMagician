using UnityEditor;
using UnityEngine;

/// <summary>
/// ヒエラルキーにアクティブ状態を切り替えるトグルを表示する拡張機能
/// </summary>

// [InitializeOnLoad]はエディタが起動またはコンパイルされた時に、このクラスを自動で呼び出す命令
[InitializeOnLoad]
public static class HierarchyActiveCheck
{
    private const int WIDTH = 16;
    private const string PLAYER_TAG = "Player";
    private const string ENEMY_TAG = "Enemy";

    // staticコンストラクタ。ヒエラルキーのアイテムを描画する時に呼ばれる
    static HierarchyActiveCheck()
    {
        EditorApplication.hierarchyWindowItemOnGUI += OnGUI;
    }

    // 描画するためのコールバックメソッド
    private static void OnGUI(int instanceID, Rect selectionRect)
    {
        // instanceIDから対応するGameObjectを取得
        GameObject gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

        // GameObjectでない場合は描画処理をスキップ
        if(gameObject == null)
        {
            return;
        }

        // タグがエネミーのときだけ
        if (gameObject.CompareTag(ENEMY_TAG))
        {
            Texture2D icon = (Texture2D)EditorGUIUtility.Load("CustomIcons/EnemyIcon.png");

            if (icon != null) 
            {
                // アイコンの場所を確保
                Rect iconRect = new Rect(selectionRect.x, selectionRect.y, 16, 16);
                // アイコンを描写
                GUI.DrawTexture(iconRect, icon);
            }
        }

        if (gameObject.CompareTag(PLAYER_TAG))
        {
            Texture2D icon = (Texture2D)EditorGUIUtility.Load("CustomIcons/PlayerIcon.png");

            if (icon != null)
            {
                // アイコンの場所を確保
                Rect iconRect = new Rect(selectionRect.x, selectionRect.y, 16, 16);
                // アイコンを描写
                GUI.DrawTexture(iconRect, icon);
            }
        }

        // トグルを表示させるための位置を調整
        // 右端にワイド分の領域を用意
        var position = selectionRect;
        position.x = position.xMax - WIDTH;
        position.width = WIDTH;

        // トグルを描画
        // ユーザーがチェックを変えたときはnewActiveが変わる
        bool newActive = GUI.Toggle(position, gameObject.activeSelf, string.Empty);

        // 状態が変わっていない場合はスルー
        if(newActive == gameObject.activeSelf)
        {
            return;
        }

        //トグルの状態に合わせて、GameObjectのアクティブ状態を変更する
        gameObject.SetActive(newActive);
    }
}
