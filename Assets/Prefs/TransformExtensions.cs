using UnityEngine;
using System.Collections;

public static class TransformExtensions {

    public static void TweenPosition(this Transform transform, float duration, Vector3 position)
    {
        Tweener tweener = transform.GetComponent<Tweener>() ?? transform.gameObject.AddComponent<Tweener>();
        tweener.TweenPosition(duration, position);
    }
}
