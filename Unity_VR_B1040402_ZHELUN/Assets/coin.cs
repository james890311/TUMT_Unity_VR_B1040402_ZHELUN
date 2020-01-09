using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{

    public int countCoin;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "平台")
        {
            Destroy(gameObject);
            countCoin += 1;
        }
        
    }
    
}
