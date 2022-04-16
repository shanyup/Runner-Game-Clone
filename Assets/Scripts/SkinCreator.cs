using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Create Skin",fileName = "New Character Skin")]
public class SkinCreator : ScriptableObject
{
    [Serializable]public struct CharacterSkin
    {
        public Sprite CharacterSprite;
        public string CharacterName;
        public int CharacterPrice;
    }

    public CharacterSkin SkinSettings;
}
