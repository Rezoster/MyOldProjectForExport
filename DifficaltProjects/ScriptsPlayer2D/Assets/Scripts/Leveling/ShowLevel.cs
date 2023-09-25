using UnityEngine;

public class ShowLevel : MonoBehaviour
{
    [SerializeField] private int level;
    [SerializeField] private GameObject button;

    private void Awake()
    {
        if(ReachedLevel.levelIndex < level)
            button.SetActive(false);
    }
}
