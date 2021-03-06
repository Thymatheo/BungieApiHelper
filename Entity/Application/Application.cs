using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Application {
    public class Application {
        /// <summary>
        /// Unique ID assigned to the application
        /// </summary>
        public int applicationId { get; set; }
        /// <summary>
        /// Name of the application
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// URL used to pass the user's authorization code to the application
        /// </summary>
        public string redirectUrl { get; set; }
        /// <summary>
        /// Link to website for the application where a user can learn more about the app.
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// Permissions the application needs to work
        /// </summary>
        public int scope { get; set; }
        /// <summary>
        /// Value of the Origin header sent in requests generated by this application.
        /// </summary>
        public string origin { get; set; }
        /// <summary>
        /// Current status of the application.
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// Date the application was first added to our database.
        /// </summary>
        public DateTime creationDate { get; set; }
        /// <summary>
        /// Date the application status last changed.
        /// </summary>
        public DateTime statusChanged { get; set; }
        /// <summary>
        /// Date the first time the application status entered the 'Public' status.
        /// </summary>
        public DateTime firstPublished { get; set; }
        /// <summary>
        /// List of team members who manage this application on Bungie.net. Will always consist of at least the application owner.
        /// </summary>
        public IEnumerable<ApplicationDeveloper> team { get; set; }
        /// <summary>
        /// An optional override for the Authorize view name.
        /// </summary>
        public string overrideAuthorizeViewName { get; set; }

    }
}
