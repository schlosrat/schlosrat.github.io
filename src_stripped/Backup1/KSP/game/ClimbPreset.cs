// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [CreateAssetMenu(fileName = "ClimbPreset", menuName = "ScriptableObjects/ClimbPreset", order = 1)]
  [DisableCustomEditorBase]
  [Serializable]
  public class ClimbPreset : ScriptableObject
  {
    public ClimbFlags Flags;
    public ClimbType Type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbPreset() => throw null;
  }
}
