using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorSubject : Subject
{
    private MeshRenderer _meshRenderer;

    protected override void Awake()
    {
        base.Awake();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    protected override void OnFaced()
    {
        _meshRenderer.material.color = Random.ColorHSV();
    }
}
