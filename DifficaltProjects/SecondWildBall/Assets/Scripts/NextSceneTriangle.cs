using UnityEngine;

public class NextSceneTriangle : MonoBehaviour
{
    [SerializeField] private PlayerControll nextScene;
    private void NextScene()
    {
        nextScene.Restart(-1);
    }
}
