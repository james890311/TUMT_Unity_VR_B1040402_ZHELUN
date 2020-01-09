using UnityEngine;
using UnityEngine.UI;

public class concount : MonoBehaviour
{
    public Text trashcount;
    public static int LostTrash = 12;

    private void Update()
    {
        trashcount.text = "金幣剩餘量：" + LostTrash;
    }
}
