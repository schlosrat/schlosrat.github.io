// Decompiled with JetBrains decompiler
// Type: MeshFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
