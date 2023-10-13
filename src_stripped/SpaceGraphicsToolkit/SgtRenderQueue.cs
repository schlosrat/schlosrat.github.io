// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRenderQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  [Serializable]
  public struct SgtRenderQueue
  {
    public SgtRenderQueue.GroupType Group;
    public int Offset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRenderQueue(SgtRenderQueue.GroupType newGroup, int newOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator int(SgtRenderQueue renderQueue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator SgtRenderQueue(SgtRenderQueue.GroupType newGroup) => throw null;

    public enum GroupType
    {
      Background = 1000, // 0x000003E8
      Geometry = 2000, // 0x000007D0
      AlphaTest = 2450, // 0x00000992
      Transparent = 3000, // 0x00000BB8
      Overlay = 4000, // 0x00000FA0
    }
  }
}
