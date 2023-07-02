// Decompiled with JetBrains decompiler
// Type: KSP.OAB.FairingVisualizationMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class FairingVisualizationMode
  {
    [JsonIgnore]
    public List<FairingPanel> Panels;
    public string VisualizationModeName;
    public float MouseInfluence;
    public ObjectAssemblyBuilderHUD OABHUD;
    protected float _cursorProximity;
    protected List<MeshRenderer> _panelRenderers;
    private float _targetOpacity;
    private float _opacity;
    protected Shader _opaqueShader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingVisualizationMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingVisualizationMode(List<FairingPanel> panels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ResetPanels(List<FairingPanel> newPanels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnVisualizationFixedUpdate(
      Vector3 mousePosition,
      float range,
      Camera mainCamera,
      float aspectCorrection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnVisualizationModeChanged(string newModeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetOpacity(float targetOpacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOpacity(float currentOpacity) => throw null;
  }
}
