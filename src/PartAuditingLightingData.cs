// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PartAuditingLightingData : MonoBehaviour
{
  public GameObject sourceLight;
  public List<GameObject> lights;
  public GameObject cubemap;
  public bool useAmbient;
  public Color ambientColor;
  public Material skybox;
  public Vector3 skyboxRotation;
  public PostProcessVolume postVolume;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PartAuditingLightingData() => throw null;
}
