// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Graphics;
using osu.Game.Rulesets.Objects;

namespace osu.Game.Rulesets.Mods
{
    public class ModWindDown<T> : ModTimeRamp<T>
        where T : HitObject
    {
        public override string Name => "Wind Down";
        public override string Acronym => "WD";
        public override string Description => "Sloooow doooown...";
        public override FontAwesome Icon => FontAwesome.fa_chevron_circle_down;
        public override double ScoreMultiplier => 1.0;
        protected override double FinalRateAdjustment => -0.25;
    }
}
