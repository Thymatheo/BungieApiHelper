using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Destiny
{
    /// <summary>
    /// <para>Information about a current character's status with a Progression.</para>
    /// <para>A progression is a value that can increase with activity and has levels.</para>
    /// <para>Think Character Level and Reputation Levels.</para>
    /// <para>Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.</para>
    /// </summary>
    public class DestinyProgression
    {
        /// <summary>
        /// <para>The hash identifier of the Progression in question.</para>
        /// <para>Use it to look up the DestinyProgressionDefinition in static data.</para>
        /// </summary>
#warning see result to understand //https://bungie-net.github.io/multi/schema_Destiny-Definitions-DestinyProgressionDefinition.html#schema_Destiny-Definitions-DestinyProgressionDefinition
        public object progressionHash { get; set; }
        /// <summary>
        /// The amount of progress earned today for this progression.
        /// </summary>
        public int dailyProgress { get; set; }
        /// <summary>
        /// If this progression has a daily limit, this is that limit.
        /// </summary>
        public int dailyLimit { get; set; }
        /// <summary>
        /// The amount of progress earned toward this progression in the current week.
        /// </summary>
        public int weeklyProgress { get; set; }
        /// <summary>
        /// If this progression has a weekly limit, this is that limit.
        /// </summary>
        public int weeklyLimit { get; set; }
        /// <summary>
        /// This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)
        /// </summary>
        public int currentProgress { get; set; }
        /// <summary>
        /// This is the level of the progression (for instance, the Character Level).
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)
        /// </summary>
        public int levelCap { get; set; }
        /// <summary>
        /// <para>Progressions define their levels in "steps".</para>
        /// <para>Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression.</para>
        /// <para>Not necessarily useful, but potentially interesting for those cruising the API.</para>
        /// <para>Relate this to the "steps" property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)</para>
        /// </summary>
        public int stepIndex { get; set; }
        /// <summary>
        /// The amount of progression (i.e. "Experience") needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.
        /// </summary>
        public int progressToNextLevel { get; set; }
        /// <summary>
        /// The number of resets of this progression you've executed this season, if applicable to this progression.
        /// </summary>
        public int? nextLevelAt { get; set; }
        /// <summary>
        /// Information about historical resets of this progression, if there is any data for it.
        /// </summary>
        public IEnumerable<DestinyProgressionResetEntry> seasonResets { get; set; }
        public IEnumerable<int> rewardItemStates { get; set; }

    }
}
