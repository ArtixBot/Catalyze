using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public AbstractAbility testAbility;
    public AbilityHolster holster1;
    public void Start(){
        testAbility = new TestAbility();
        holster1 = gameObject.AddComponent<AbilityHolster>() as AbilityHolster;
        holster1.abilityData = testAbility;
    }

    public void Update(){
        if (Input.GetMouseButtonDown(0)){
            holster1.Activate();
        }
    }
}
