using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class BattleSystem : MonoBehaviour
    {
        [SerializeField] TurnTracker _turnTracker;

        public TurnTracker TurnTracker => _turnTracker;

        public List<Hero> Party { get; private set; } = new List<Hero>();
        public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

        public void Initialize(List<Hero> party, List<Enemy> enemies)
        {
            SetupHeroes(party);
            SetupEnemies(enemies);
        }

        private void SetupEnemies(List<Enemy> enemies)
        {
            Enemies.Clear();
            Enemies = enemies;
        }

        private void SetupHeroes(List<Hero> party)
        {
            Party.Clear();
            Party = party;
        }

        // this method activates all units so that they can perform actions as needed
        public void Progress()
        {
            foreach(Hero hero in Party)
            {
                hero.ShouldProgress = true;
            }
            foreach(Enemy enemy in Enemies)
            {
                enemy.ShouldProgress = true;
            }
        }

        // this method deactivates all units
        public void PauseProgression()
        {
            foreach (Hero hero in Party)
            {
                hero.ShouldProgress = false;
            }
            foreach (Enemy enemy in Enemies)
            {
                enemy.ShouldProgress = false;
            }
        }
    }
}

