using UnityEngine;

public class CursorManager
{
    private static readonly CursorManager instance = new CursorManager();
    static CursorManager() { }
    private CursorManager() { }
    public static CursorManager Instance
    {
        get
        {
            return instance;
        }
    }
    public void LockCursor() => Cursor.lockState = CursorLockMode.Locked;
    public void UnlockCursor() => Cursor.lockState = CursorLockMode.None;
}
