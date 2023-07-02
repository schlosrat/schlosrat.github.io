// Decompiled with JetBrains decompiler
// Type: KSP.UI.Examples.DebugBindings_VAB_Tools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.OAB;
using KSP.UI.Binding.Group;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Examples
{
  public class DebugBindings_VAB_Tools : DebugBindings_Root
  {
    [SerializeField]
    [Header("Faux Game Data")]
    private AssemblyPartAttachmentType snapMode;
    [SerializeField]
    private BuilderSymmetryMode symmetryMode;
    [SerializeField]
    private int undoCount;
    [SerializeField]
    private DebugBindings_VAB_Tools.Mock_PartManipulationMode partManipulationMode;
    [SerializeField]
    private bool canSeeCenterOfDrag;
    [SerializeField]
    private bool canSeeCenterOfThrust;
    [SerializeField]
    private bool canSeeCenterOfMass;
    [SerializeField]
    private bool canSeeCenterOfRadiation;
    [Space(15f)]
    [SerializeField]
    private UIGroup_VABTools toolsGroup;
    private PropertyExternal<bool> rocketOrPlaneProp;
    private PropertyExternal<bool> snapModeProp;
    private PropertyExternal<string> symmetryModeProp;
    private PropertyExternal<int> undoProp;
    private PropertyExternal<string> partManipulationProp;
    private PropertyExternal<bool> canSeeCenterOfDragProp;
    private PropertyExternal<bool> canSeeCenterOfThrustProp;
    private PropertyExternal<bool> canSeeCenterOfMassProp;
    private PropertyExternal<bool> canSeeCenterOfRadiationProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnQueuedValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AutoChangeValueTick(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugBindings_VAB_Tools() => throw null;

    private enum Mock_PartManipulationMode
    {
      SELECT,
      MANIPULATE,
      ANCHOR,
      LAUNCH,
    }
  }
}
