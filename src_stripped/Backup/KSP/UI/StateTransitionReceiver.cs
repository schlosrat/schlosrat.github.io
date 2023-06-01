// Decompiled with JetBrains decompiler
// Type: KSP.UI.StateTransitionReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (Graphic))]
  public class StateTransitionReceiver : KerbalMonoBehaviour
  {
    [SerializeField]
    private ColorBlock _colors;
    [SerializeField]
    private Graphic _targetGraphic;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReceiveStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StateTransitionReceiver() => throw null;
  }
}
