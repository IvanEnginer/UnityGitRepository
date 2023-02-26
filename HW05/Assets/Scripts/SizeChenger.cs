using UnityEngine;

public class SizeChenger : MonoBehaviour
{
    public void ChangeSize(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
}
