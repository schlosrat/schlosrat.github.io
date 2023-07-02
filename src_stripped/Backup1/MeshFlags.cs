// Decompiled with JetBrains decompiler
// Type: MeshFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

[Flags]
public enum MeshFlags
{
  None = 0,
  Generator = 1,
  Count = 2,
  Color = 4,
  Speed = 8,
  Surface = 16, // 0x00000010
  Seed = Surface | Speed | Color, // 0x0000001C
  All = Seed | Count | Generator, // 0x0000001F
}
