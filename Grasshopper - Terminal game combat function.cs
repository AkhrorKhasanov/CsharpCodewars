using System;

public static class Game
{
  public static float Combat(float health, float damage)
  {
    if (health - damage <= 0) {
      return 0;
    }
    return health - damage;
  }
}