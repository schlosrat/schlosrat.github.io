// Decompiled with JetBrains decompiler
// Type: IMultipleDragCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

public interface IMultipleDragCube
{
  string[] GetDragCubeNames();

  void AssumeDragCubePosition(string name);

  bool UsesProceduralDragCubes();

  bool IsMultipleCubesActive { get; }
}
