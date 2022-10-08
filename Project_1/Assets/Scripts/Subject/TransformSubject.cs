using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class TransformSubject : Subject
{
    private MeshFilter _meshFilter;
    
    [SerializeField] private Mesh[] meshes;

    protected override void Awake()
    {
        base.Awake();
        _meshFilter = GetComponent<MeshFilter>();
    }

    protected override void OnFaced()
    {
        _meshFilter.mesh = meshes[Random.Range(0, meshes.Length)];
    }
}
