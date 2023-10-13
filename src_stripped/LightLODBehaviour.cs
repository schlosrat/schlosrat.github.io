// Decompiled with JetBrains decompiler
// Type: LightLODBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightLODBehaviour : KerbalMonoBehaviour
{
  public Light PointLight;
  public MeshRenderer LightQuad;
  private LightCullingManager _lightCullingManager;
  private int _index;
  private Transform _thisTransform;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LightLODBehaviour() => throw null;
}
