// Decompiled with JetBrains decompiler
// Type: RTG.SceneRaycastHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class SceneRaycastHit
  {
    private GameObjectRayHit _objectHit;
    private XZGridRayHit _gridHit;

    public bool WasAnythingHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool WasAnObjectHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool WasGridHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObjectRayHit ObjectHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public XZGridRayHit GridHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit) => throw null;
  }
}
