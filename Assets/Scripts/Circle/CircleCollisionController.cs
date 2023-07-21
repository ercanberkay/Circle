
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleCollisionController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Line"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
