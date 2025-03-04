using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject startButton; // Başlat Butonu
    [SerializeField] private GameObject player; // Oyuncu karakteri

    private void Start()
    {
        Time.timeScale = 0; // Oyun başta durdurulmuş olacak
        startButton.SetActive(true); // Buton başta görünür olacak
        Debug.Log("Oyun durduruldu, buton aktif!");
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Oyun başlasın
        startButton.SetActive(false); // Butonu gizle
        Debug.Log("Oyun başladı, buton gizlendi!");
    }

    public void GameOver()
    {
        // Sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Death Collider için örnek bir method
    public void OnDeathColliderEnter()
    {
        GameOver(); // Oyunu yeniden başlat
    }
}