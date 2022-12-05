using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAME_OVER : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;
    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);
    }
    private void Awake();
    void Start();


        void SpawnPLatforms();
        void Spawn10More();
        public void TouchedPlatform(string name);
}
