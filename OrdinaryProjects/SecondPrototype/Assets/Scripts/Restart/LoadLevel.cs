using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    private const string Portal = "Portal";
    private const string Portal1 = "Portal1";
    private const string Portal2 = "Portal2";

    [SerializeField] private NextOrReloadLevel nextLevel;

    public void LoadingLevel(string levelTag)
    {
        switch (levelTag)
        {
            case Portal:
                nextLevel.Restart(-1);
                break;
            case (Portal1):
                nextLevel.Restart(1);
                break;
            case (Portal2):
                nextLevel.Restart();
                break;
        }
    }
}
