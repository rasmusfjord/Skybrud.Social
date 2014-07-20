using System.Collections.Generic;
using System.Linq;
using Skybrud.Social.Json;

namespace Skybrud.Social.Twitter.Entities {
    
    public class TwitterUserUrlEntities {

        #region Properties

        /// <summary>
        /// Gets an array of URLs specified in the URL field for a user. Twitter users can only
        /// specify a single URL in their profiles, but an array is still returned by the Twitter
        /// API.
        /// </summary>
        public TwitterUrlEntitity[] Urls { get; private set; }

        #endregion

        #region Constructor(s)

        private TwitterUserUrlEntities() {
            // Hide default constructor
        }

        #endregion

        #region Member method(s)

        /// <summary>
        /// Gets a collection of all entities in ascending order.
        /// </summary>
        public IOrderedEnumerable<TwitterBaseEntity> GetAll() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(Urls);
            return temp.OrderBy(x => x.StartIndex);
        }

        /// <summary>
        /// Gets a collection of all entities in descending order.
        /// </summary>
        public IOrderedEnumerable<TwitterBaseEntity> GetAllReversed() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(Urls);
            return temp.OrderByDescending(x => x.StartIndex);
        }

        #endregion

        #region Static method(s)

        /// <summary>
        /// Parses a given instance of <code>JsonObject</code>.
        /// </summary>
        /// <param name="entities">The <code>JsonObject</code> to be parsed.</param>
        public static TwitterUserUrlEntities Parse(JsonObject entities) {
            if (entities == null) return null;
            return new TwitterUserUrlEntities {
                Urls = entities.GetArray("urls", TwitterUrlEntitity.Parse)
            };
        }

        #endregion

    }

}