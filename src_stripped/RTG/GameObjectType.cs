// Decompiled with JetBrains decompiler
// Type: RTG.GameObjectType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace RTG
{
  [Flags]
  public enum GameObjectType
  {
    Mesh = 1,
    Terrain = 2,
    Sprite = 4,
    Camera = 8,
    Light = 16, // 0x00000010
    ParticleSystem = 32, // 0x00000020
    Empty = 64, // 0x00000040
  }
}
