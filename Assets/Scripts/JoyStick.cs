using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public RectTransform joyStickObj;

    private void Awake()
    {
        joyStickObj = GetComponent<RectTransform>();
    }
}
