// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
