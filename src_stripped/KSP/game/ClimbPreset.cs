// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [DisableCustomEditorBase]
  [CreateAssetMenu(fileName = "ClimbPreset", menuName = "ScriptableObjects/ClimbPreset", order = 1)]
  [Serializable]
  public class ClimbPreset : ScriptableObject
  {
    public ClimbFlags Flags;
    public ClimbType Type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbPreset() => throw null;
  }
}
