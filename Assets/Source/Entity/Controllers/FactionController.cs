﻿using UnityEngine;

namespace Crab.Controllers
{

    public class FactionController : AIController
    {
        void EnterCombat(Entity target) { }
        void JustDead(Entity killer) { }
        void JustKilled(Entity victim) { }
        protected override void AnyDamage(int damage, Entity damageCauser, DamageType damageType) { }
    }
}