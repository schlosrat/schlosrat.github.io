// Decompiled with JetBrains decompiler
// Type: KSP.UI.StateTransitionReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
