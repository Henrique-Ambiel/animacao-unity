using UnityEngine;

public class AniamationManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Animator>().Play("Idle");
        Debug.Log("AnimationManager: Start");
    }
}
