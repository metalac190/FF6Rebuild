using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This class holds the current encounter data for each of the party members.
/// This is also the 'HUB' for gaining access to anything related to this party member
/// </summary>

namespace RPG.Encounter
{
    public class Hero : Unit
    {
        public EquipmentLoader EquipmentLoader { get; private set; }

        public void Initialize(HeroData data)
        {
            base.Initialize(data);
            
            SetupSlots();
            //TODO fill in starting Equipment
            SetStartingEquipment(data);
        }

        private void SetupSlots()
        {
            EquipSlot[] equipSlots = new EquipSlot[7];
            equipSlots[0] = new RightHandEquipSlot("Right Hand");
            equipSlots[1] = new LeftHandEquipSlot("Left Hand");
            equipSlots[2] = new HeadEquipSlot("Head");
            equipSlots[3] = new BodyEquipSlot("Body");
            equipSlots[4] = new FootEquipSlot("Foot");
            equipSlots[5] = new RelicEquipSlot("Relic 01");
            equipSlots[6] = new RelicEquipSlot("Relic 02");

            EquipmentLoader = new EquipmentLoader(equipSlots);
        }

        void SetStartingEquipment(HeroData data)
        {

        }
    }
}

