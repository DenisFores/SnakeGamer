using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform segmentPrefab;
    public float followSpeed = 10f;

    private List<Transform> segments = new List<Transform>();

    public void AddSegment()
    {
        Transform seg = Instantiate(segmentPrefab);
        seg.position = transform.position;
        segments.Add(seg);
    }

    void Update()
    {
        for (int i = 0; i < segments.Count; i++)
        {
            Transform target = (i == 0) ? transform : segments[i - 1];

            segments[i].position = Vector3.Lerp(
                segments[i].position,
                target.position,
                Time.deltaTime * followSpeed
            );

            // уменьшение размера
            float scale = 1f - (i * 0.05f);
            segments[i].localScale = Vector3.one * scale;
        }
    }
}