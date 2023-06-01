// Decompiled with JetBrains decompiler
// Type: KSP.OAB.FairingExplodedVisibility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class FairingExplodedVisibility : FairingVisualizationMode
  {
    private float _explodedT;
    private float _targetExplodedT;
    private List<FairingClamshellGroup> _clamshellGroups;
    protected Shader _transparentShader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingExplodedVisibility(string modeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ResetPanels(List<FairingPanel> newPanels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnVisualizationFixedUpdate(
      Vector3 mousePosition,
      float range,
      Camera mainCamera,
      float aspectCorrection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnVisualizationModeChanged(string newModeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExplodedView(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetExplodedView(float t) => throw null;
  }
}
