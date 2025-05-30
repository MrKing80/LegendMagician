using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

/// <summary>
/// ����ҁF�ʈ�
/// </summary>

// ScriptableIcon�N���X�ɑΉ������J�X�^��Inspector�����錾
// ��������true������ƁA�Y���N���X���p�������q�N���X���K�p�����
[CustomEditor(typeof(BaseAttribute), true)]
// �G�f�B�^��ł̌����ڂ⓮����J�X�^�}�C�Y���邽�߂̃N���X
public class IconChange : Editor
{
    // �v���W�F�N�g�r���[�ɕ\�������A�C�R���摜���J�X�^�}�C�Y���鏈��
    public override Texture2D RenderStaticPreview
    (
        // �A�Z�b�g�̃p�X�i�����󂯓n���j
        string assetPath,
        // �A�Z�b�g�ɕR�Â��ǉ��I�u�W�F�N�g����
        Object[] subAssets,
        // �v���r���[�摜�̕��ƍ���
        int width, 
        int height
     )
    {
        // �ҏW�Ώۂ̃I�u�W�F�N�g��ScriptableIcon�^�ɕϊ�
        BaseAttribute obj = target as BaseAttribute;
        // ScriptableIcon�N���X����icon�ϐ����擾
        Sprite icon = obj.Icon;

        // �����A�C�R�����ݒ肳��Ă��Ȃ����
        if (icon == null)
        {
            // �f�t�H���g�̏������s��
            return base.RenderStaticPreview(assetPath, subAssets, width, height);
        }

        // �A�C�R���摜�̃v���r���[���擾
        Texture2D preview = AssetPreview.GetAssetPreview(icon);

        if (preview == null)
        {
            // �f�t�H���g�̏������s��
            return base.RenderStaticPreview(assetPath, subAssets, width, height);
        }

        // �V������̉摜���쐬�i�v���r���[�摜�T�C�Y�j
        Texture2D final = new Texture2D(width, height);

        // preview�̒��g��final�ɃR�s�[�i���g�ۂ��ƕ����j
        EditorUtility.CopySerialized(preview, final);

        // �쐬�����摜��Ԃ��iUnity�������\������j
        return final;
    }
}
#endif