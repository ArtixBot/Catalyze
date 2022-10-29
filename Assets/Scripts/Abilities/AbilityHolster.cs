using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolster : MonoBehaviour {

    public AbstractAbility abilityData;
    private bool isUsable = true;

    public void Activate(){
        if (!isUsable){
            Debug.LogWarning("Ability on cooldown!");
            return;
        }
        StartCoroutine(Cooldown());
        isUsable = false;
        Debug.Log("Casting ability");
    }

    private IEnumerator Cooldown(){
        yield return new WaitForSeconds(abilityData.ABILITY_COOLDOWN);
        isUsable = true;
    }
}