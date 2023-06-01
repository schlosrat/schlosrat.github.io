// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
