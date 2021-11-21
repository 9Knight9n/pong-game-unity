using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "PaddleConfig")]
public class PaddleConfig : ScriptableObject
{
    public string name;
    public float direction;
}