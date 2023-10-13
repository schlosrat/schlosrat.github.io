// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.JointConnectionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.DebugTools
{
  internal class JointConnectionItem : FlightToolsItem<PartOwnerBehavior.JointConnection>
  {
    [SerializeField]
    private TextMeshProUGUI _textNumJoints;
    [SerializeField]
    private TextMeshProUGUI _textHostName;
    [SerializeField]
    private TextMeshProUGUI _textTargetName;
    [SerializeField]
    private TextMeshProUGUI _textAttachmentType;
    [SerializeField]
    private TextMeshProUGUI _textJointType;
    private static string[] ATTACH_NODE_TYPE_ENUM_NAMES;
    private static string[] JOINT_CONNECTION_TYPE_ENUM_NAMES;
    private static readonly string[] ZERO_TO_NINE_STRINGS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(PartOwnerBehavior.JointConnection jointConnection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyJoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JointConnectionItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static JointConnectionItem() => throw null;
  }
}
