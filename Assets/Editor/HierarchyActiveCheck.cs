using UnityEditor;
using UnityEngine;

/// <summary>
/// �q�G�����L�[�ɃA�N�e�B�u��Ԃ�؂�ւ���g�O����\������g���@�\
/// </summary>

// [InitializeOnLoad]�̓G�f�B�^���N���܂��̓R���p�C�����ꂽ���ɁA���̃N���X�������ŌĂяo������
[InitializeOnLoad]
public static class HierarchyActiveCheck
{
    private const int WIDTH = 16;
    private const string PLAYER_TAG = "Player";
    private const string ENEMY_TAG = "Enemy";

    // static�R���X�g���N�^�B�q�G�����L�[�̃A�C�e����`�悷�鎞�ɌĂ΂��
    static HierarchyActiveCheck()
    {
        EditorApplication.hierarchyWindowItemOnGUI += OnGUI;
    }

    // �`�悷�邽�߂̃R�[���o�b�N���\�b�h
    private static void OnGUI(int instanceID, Rect selectionRect)
    {
        // instanceID����Ή�����GameObject���擾
        GameObject gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

        // GameObject�łȂ��ꍇ�͕`�揈�����X�L�b�v
        if(gameObject == null)
        {
            return;
        }

        // �^�O���G�l�~�[�̂Ƃ�����
        if (gameObject.CompareTag(ENEMY_TAG))
        {
            Texture2D icon = (Texture2D)EditorGUIUtility.Load("CustomIcons/EnemyIcon.png");

            if (icon != null) 
            {
                // �A�C�R���̏ꏊ���m��
                Rect iconRect = new Rect(selectionRect.x, selectionRect.y, 16, 16);
                // �A�C�R����`��
                GUI.DrawTexture(iconRect, icon);
            }
        }

        if (gameObject.CompareTag(PLAYER_TAG))
        {
            Texture2D icon = (Texture2D)EditorGUIUtility.Load("CustomIcons/PlayerIcon.png");

            if (icon != null)
            {
                // �A�C�R���̏ꏊ���m��
                Rect iconRect = new Rect(selectionRect.x, selectionRect.y, 16, 16);
                // �A�C�R����`��
                GUI.DrawTexture(iconRect, icon);
            }
        }

        // �g�O����\�������邽�߂̈ʒu�𒲐�
        // �E�[�Ƀ��C�h���̗̈��p��
        var position = selectionRect;
        position.x = position.xMax - WIDTH;
        position.width = WIDTH;

        // �g�O����`��
        // ���[�U�[���`�F�b�N��ς����Ƃ���newActive���ς��
        bool newActive = GUI.Toggle(position, gameObject.activeSelf, string.Empty);

        // ��Ԃ��ς���Ă��Ȃ��ꍇ�̓X���[
        if(newActive == gameObject.activeSelf)
        {
            return;
        }

        //�g�O���̏�Ԃɍ��킹�āAGameObject�̃A�N�e�B�u��Ԃ�ύX����
        gameObject.SetActive(newActive);
    }
}
