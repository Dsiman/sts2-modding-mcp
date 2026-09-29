using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Runs;

namespace MCPTest;

/// <summary>
/// Shims for game APIs removed in newer STS2 builds (v0.111 beta).
/// </summary>
internal static class GameCompat
{
    /// <summary>
    /// Replacement for the removed <c>CombatManager.IsPlayPhase</c>: true while
    /// combat is running and the action synchronizer is in its player
    /// play phase (the state CombatManager sets when a player turn opens).
    /// </summary>
    public static bool IsPlayPhase(this CombatManager cm)
        => cm.IsInProgress
           && RunManager.Instance?.ActionQueueSynchronizer?.CombatState == ActionSynchronizerCombatState.PlayPhase;
}
