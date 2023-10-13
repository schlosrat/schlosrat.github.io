// Decompiled with JetBrains decompiler
// Type: Test_PlanetShineController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class Test_PlanetShineController : MonoBehaviour
{
  [Header("Sun")]
  public GameObject sun;
  private Color sunColor;
  public float sunIntensity;
  private float sunRadius;
  private float sunDistance;
  private Renderer sunRend;
  [Header("Orbiting Body 01")]
  public GameObject body01;
  private Color body01_Color;
  public float body01_Reflectivity;
  private float body01_Radius;
  private float body01_Distance;
  private Renderer body01_Rend;
  [Header("Orbiting Body 02")]
  public GameObject body02;
  private Color body02_Color;
  public float body02_Reflectivity;
  private float body02_Radius;
  private float body02_Distance;
  private Renderer body02_Rend;
  [Header("Orbiting Body 03")]
  public GameObject body03;
  private Color body03_Color;
  public float body03_Reflectivity;
  private float body03_Radius;
  private float body03_Distance;
  private Renderer body03_Rend;
  [Header("Debug")]
  public float debugScalar;
  public Renderer myRend;
  [SerializeField]
  private float angle;
  [SerializeField]
  private float angleInt;
  [SerializeField]
  private float finalSun;
  [SerializeField]
  private float finalOrbiting;
  [SerializeField]
  private float planetShineIntensity;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float CalculateIntensity(GameObject star, GameObject body) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float remap(float s, float a1, float a2, float b1, float b2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Test_PlanetShineController() => throw null;
}
