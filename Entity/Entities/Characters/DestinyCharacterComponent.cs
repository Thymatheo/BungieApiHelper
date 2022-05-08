using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Destiny;
using BungieApiHelper.Entity.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Entities.Characters {
    public class DestinyCharacterComponent {
        /// <summary>
        /// Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.
        /// </summary>
        public string membershipId { get; set; }
        /// <summary>
        /// membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.
        /// </summary>
        public BungieMembershipType membershipType { get; set; }
        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public int characterId { get; set; }
        /// <summary>
        /// The last date that the user played Destiny.
        /// </summary>
        public DateTime dateLastPlayed { get; set; }
        /// <summary>
        /// If the user is currently playing, this is how long they've been playing.
        /// </summary>
        public int minutesPlayedThisSession { get; set; }
        /// <summary>
        /// If this value is 525,600, then they played Destiny for a year. Or they're a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.
        /// </summary>
        public int minutesPlayedTotal { get; set; }
        /// <summary>
        /// The user's calculated "Light Level". Light level is an indicator of your power that mostly matters in the end game, once you've reached the maximum character level: it's a level that's dependent on the average Attack/Defense power of your items.
        /// </summary>
        public int light { get; set; }
        /// <summary>
        /// Your character's stats, such as Agility, Resilience, etc... *not* historical stats.
        /// </summary>
        public Dictionary<int, int> stats { get; set; }
        /// <summary>
        /// /Use this hash to look up the character's DestinyRaceDefinition.
        /// </summary>
        public int raceHash { get; set; }
        /// <summary>
        /// Use this hash to look up the character's DestinyGenderDefinition.
        /// </summary>
        public int genderHash { get; set; }
        /// <summary>
        /// Use this hash to look up the character's DestinyClassDefinition.
        /// </summary>
        public int classHash { get; set; }
        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's race.
        /// </summary>
        public DestinyRace raceType { get; set; }
        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's class.
        /// </summary>
        public DestinyGender classType { get; set; }
        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's Gender.
        /// </summary>
        public DestinyGender genderType { get; set; }
        /// <summary>
        /// A shortcut path to the user's currently equipped emblem image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        public string emblemPath { get; set; }
        /// <summary>
        /// A shortcut path to the user's currently equipped emblem background image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        public string emblemBackgroundPath { get; set; }
        /// <summary>
        /// The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
        /// </summary>
        public int emblemHash { get; set; }
        /// <summary>
        /// A shortcut for getting the background color of the user's currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.
        /// </summary>
        public DestinyColor emblemColor { get; set; }
        /// <summary>
        /// The progression that indicates your character's level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.
        /// </summary>
        public DestinyProgression levelProgression { get; set; }
        /// <summary>
        /// /The "base" level of your character, not accounting for any light level.
        /// </summary>
        public int baseCharacterLevel { get; set; }
        /// <summary>
        /// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.
        /// </summary>
        public float percentToNextLevel { get; set; }
        /// <summary>
        /// If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
        /// </summary>
        public float titleRecordHash { get; set; }
    }
}
