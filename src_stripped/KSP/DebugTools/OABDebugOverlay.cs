// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.OABDebugOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.DebugTools
{
  public class OABDebugOverlay : MonoBehaviour
  {
    [SerializeField]
    private OABDebugOverlayText template;
    [SerializeField]
    private float pollRateSeconds;
    [SerializeField]
    private bool autoRefresh;
    [Range(0.1f, 0.8f)]
    [SerializeField]
    private float locFromPartToCam;
    private GameObjectPool<OABDebugOverlayText> textPool;
    private double timeRemaining;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABDebugOverlay() => throw null;
  }
}
