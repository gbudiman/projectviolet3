using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbabilisticMechanic {
  /// <summary>
  /// Roll dice in uniform probability distribution
  /// </summary>
  /// <returns>The roll.</returns>
  /// <param name="min">Minimum.</param>
  /// <param name="max">Max.</param>
  public static bool Roll(float min, float max) {
    return false;
  }

  /// <summary>
  /// Roll dice in gaussian probability distribution
  /// </summary>
  /// <returns>The roll.</returns>
  /// <param name="min">Minimum.</param>
  /// <param name="max">Max.</param>
  /// <param name="mu">Mu.</param>
  /// <param name="sigma">Sigma.</param>
  public static bool Roll(float min, float max, float mu, float sigma) {
    return false;
  }

  /// <summary>
  /// Add jitter 
  /// </summary>
  /// <returns>The jitter.</returns>
  /// <param name="mu">Mu.</param>
  /// <param name="sigma">Sigma.</param>
  public static float Jitter(float mu, float sigma) {
    return 0;
  }
}