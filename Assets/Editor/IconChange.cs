using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

/// <summary>
/// 制作者：玉井
/// </summary>

// ScriptableIconクラスに対応したカスタムInspectorを作る宣言
// 第二引数にtrueを入れると、該当クラスを継承した子クラスも適用される
[CustomEditor(typeof(BaseAttribute), true)]
// エディタ上での見た目や動作をカスタマイズするためのクラス
public class IconChange : Editor
{
    // プロジェクトビューに表示されるアイコン画像をカスタマイズする処理
    public override Texture2D RenderStaticPreview
    (
        // アセットのパス（自動受け渡し）
        string assetPath,
        // アセットに紐づく追加オブジェクトたち
        Object[] subAssets,
        // プレビュー画像の幅と高さ
        int width, 
        int height
     )
    {
        // 編集対象のオブジェクトをScriptableIcon型に変換
        BaseAttribute obj = target as BaseAttribute;
        // ScriptableIconクラス内のicon変数を取得
        Sprite icon = obj.Icon;

        // もしアイコンが設定されていなければ
        if (icon == null)
        {
            // デフォルトの処理を行う
            return base.RenderStaticPreview(assetPath, subAssets, width, height);
        }

        // アイコン画像のプレビューを取得
        Texture2D preview = AssetPreview.GetAssetPreview(icon);

        if (preview == null)
        {
            // デフォルトの処理を行う
            return base.RenderStaticPreview(assetPath, subAssets, width, height);
        }

        // 新しい空の画像を作成（プレビュー画像サイズ）
        Texture2D final = new Texture2D(width, height);

        // previewの中身をfinalにコピー（中身丸ごと複製）
        EditorUtility.CopySerialized(preview, final);

        // 作成した画像を返す（Unityがこれを表示する）
        return final;
    }
}
#endif