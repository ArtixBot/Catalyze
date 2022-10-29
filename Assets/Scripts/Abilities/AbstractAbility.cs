using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityTag {MELEE, RANGED, UTILITY};
public abstract class AbstractAbility {

    public readonly string ABILITY_NAME;
    public List<AbilityTag> ABILITY_TAGS;
    public float ABILITY_COOLDOWN;              // in seconds
    
    public bool HasTag(AbilityTag abilityTag){
        return this.ABILITY_TAGS.Contains(abilityTag);
    }
}

public class TestAbility : AbstractAbility {
    
    public TestAbility(){
        this.ABILITY_COOLDOWN = 1f;
    }
}