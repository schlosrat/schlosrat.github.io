// Decompiled with JetBrains decompiler
// Type: KSP.OAB.UIStateVisualsBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
