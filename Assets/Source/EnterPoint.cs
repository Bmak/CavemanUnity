using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace Caveman
{
    public class EnterPoint : MonoBehaviour
    {
        public Text time;
        public Text countDethPlayer;

        private Player humanPlayer;
        private Random random;

        public void Start()
        {
            random = new Random();
            

            var prefabPlayer = Instantiate(Resources.Load("skin_1", typeof(GameObject))) as GameObject;
            var playerModel = prefabPlayer.GetComponent<PlayerModel>();
            humanPlayer = new Player("Kiracosyan", 1);
            playerModel.player = humanPlayer;

            var player2 = Instantiate(Resources.Load("skin_1", typeof(GameObject))) as GameObject;
            var player2Model = player2.GetComponent<PlayerModel>();
            player2Model.player = new Player("Zabiyakin", 2);
        }

        public void Update()
        {
            time.text = Time.time.ToString();
            //countDethPlayer.text = humanPlayer.death.ToString();
        }

        private void IniPlayers()
        {
            
        }
    }
}
