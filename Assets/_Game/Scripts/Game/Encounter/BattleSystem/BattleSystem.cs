using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RPG.Encounter
{
    public class BattleSystem : MonoBehaviour
    {
        public event Action<ICommand> NewCommand = delegate { };

        public LoopedSelector<Unit> UnitsReady { get; private set; } = new LoopedSelector<Unit>();

        public List<Hero> Party { get; private set; } = new List<Hero>();
        public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

        public void Initialize(List<Hero> party, List<Enemy> enemies)
        {
            SetupHeroes(party);
            SetupEnemies(enemies);
            Subscribe();
        }

        private void OnDestroy()
        {
            Unsubscribe();
        }

        void Subscribe()
        {
            // cycle through and subscribe
            foreach(Unit unit in Party)
            {
                unit.ReadyForActionState.ReadyChanged += OnUnitReadyChanged;
            }
            foreach(Unit unit in Enemies)
            {
                unit.ReadyForActionState.ReadyChanged += OnUnitReadyChanged;
            }
        }

        void Unsubscribe()
        {
            // cycle through and subscribe
            foreach (Unit unit in Party)
            {
                unit.ReadyForActionState.ReadyChanged -= OnUnitReadyChanged;
            }
            foreach (Unit unit in Enemies)
            {
                unit.ReadyForActionState.ReadyChanged -= OnUnitReadyChanged;
            }
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
                hero.IsActive = true;
            }
            foreach(Enemy enemy in Enemies)
            {
                enemy.IsActive = true;
            }
        }

        // this method deactivates all units
        public void PauseProgression()
        {
            foreach (Hero hero in Party)
            {
                hero.IsActive = false;
            }
            foreach (Enemy enemy in Enemies)
            {
                enemy.IsActive = false;
            }
        }

        public void CommandUnit(Unit unit, ICommand command)
        {

        }

        void OnUnitReadyChanged(bool isReady, Unit unit)
        {
            Debug.Log("Unit Ready: " + unit.Name);
        }
    }
}

