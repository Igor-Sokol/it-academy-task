using UnityEngine;

public class ScaleSubject : Subject
{
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    
    protected override void OnFaced()
    {
        float newScale = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
