using UnityEngine;

// �⑫����  
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class NitouhenSankakkeiMesh : MonoBehaviour
{
    private void Start()
    {
        // ���b�V���̍쐬  
        var mesh = new Mesh();

        // ���_���W�z������b�V���ɃZ�b�g  
        mesh.SetVertices(new Vector3[] {
            new Vector3 (0, 1f),
            new Vector3 (1f, -1f),
            new Vector3 (-1f, -1f),
        });

        // �C���f�b�N�X�z������b�V���ɃZ�b�g  
        mesh.SetTriangles(new int[] {
            0, 1, 2
        }, 0);

        // MeshFilter��ʂ��ă��b�V����MeshRenderer�ɃZ�b�g  
        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;
    }
}