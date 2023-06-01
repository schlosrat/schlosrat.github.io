// Decompiled with JetBrains decompiler
// Type: KSP.OAB.UIStateVisualsBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class UIStateVisualsBase : MonoBehaviour
  {
    protected bool currentState;
    [SerializeField]
    protected Image target;
    [SerializeField]
    protected VisualCollection onRest;
    [SerializeField]
    protected VisualCollection onHover;
    [SerializeField]
    protected VisualCollection onPress;
    [SerializeField]
    protected VisualCollection onDrag;
    [SerializeField]
    protected VisualCollection onActive;
    [SerializeField]
    protected VisualCollection onActiveAlt;
    [SerializeField]
    protected VisualCollection onDisabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetState(UIVisualState_PROTOTYPE state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTargetsToCollection(VisualCollection toSetTargetsTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool IsCurrentState(VisualCollection checkState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIStateVisualsBase() => throw null;
  }
}
