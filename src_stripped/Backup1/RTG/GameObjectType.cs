// Decompiled with JetBrains decompiler
// Type: RTG.GameObjectType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
