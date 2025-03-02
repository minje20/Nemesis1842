using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CharacterData",order = Int32.MaxValue)]
public class CharacterData : ScriptableObject
{
    [SerializeField]
    private string _characterCode;

    public string CharacterCode => _characterCode;
    
    [SerializeField]
    private string _characterName;

    public string CharacterName => _characterName;
    
    [SerializeField]
    private Sprite[] _characterSprite;
    
    public Sprite[] CharacterSprite => _characterSprite;
}