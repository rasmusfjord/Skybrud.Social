using System.Collections.Specialized;
using System.Globalization;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.OAuth;
using Skybrud.Social.Twitter.Options;

namespace Skybrud.Social.Twitter.Endpoints.Raw {

    public class TwitterFollowersRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth 1.0a client.
        /// </summary>
        public TwitterOAuthClient Client { get; private set; }

        #endregion

        #region Constructor

        internal TwitterFollowersRawEndpoint(TwitterOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a list of IDs representing the friends of a given user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        public SocialHttpResponse GetIdsFromUserId(long userId) {
            return GetIdsFromUserId(userId, null);
        }

        /// <summary>
        /// Gets a list of IDs representing the friends of a given user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="options">The options for the call.</param>
        public SocialHttpResponse GetIdsFromUserId(long userId, TwitterFollowersIdsOptions options) {

            // Define the query string
            NameValueCollection query = new NameValueCollection {
                {"user_id", userId.ToString(CultureInfo.InvariantCulture)}
            };

            // Update the query string with the specified options
            if (options != null) options.UpdateNameValueCollection(query);

            // Make the call to the API
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/ids.json", query);

        }

        /// <summary>
        /// Gets a list of IDs representing the friends of a given user.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        public SocialHttpResponse GetIdsFromScreenName(string screenName) {
            return GetIdsFromScreenName(screenName, null);
        }

        /// <summary>
        /// Gets a list of IDs representing the friends of a given user.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="options">The options for the call.</param>
        public SocialHttpResponse GetIdsFromScreenName(string screenName, TwitterFollowersIdsOptions options) {

            // Define the query string
            NameValueCollection query = new NameValueCollection {
                {"screenName", screenName}
            };

            // Update the query string with the specified options
            if (options != null) options.UpdateNameValueCollection(query);

            // Make the call to the API
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/ids.json", query);

        }

        /// <summary>
        /// Gets a list of friends for a given user using the default options.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        public SocialHttpResponse GetListFromUserId(long userId) {
            return GetListFromUserId(userId, null);
        }

        /// <summary>
        /// Gets a list of friends for a given user using the default options.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="options">The options for the call.</param>
        public SocialHttpResponse GetListFromUserId(long userId, TwitterFollowersListOptions options) {

            // Define the query string
            NameValueCollection query = new NameValueCollection {
                {"user_id", userId.ToString(CultureInfo.InvariantCulture)}
            };

            // Update the query string with the specified options
            if (options != null) options.UpdateNameValueCollection(query);

            // Make the call to the API
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/list.json", query);

        }

        /// <summary>
        /// Gets a list of friends for a given user using the default options.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        public SocialHttpResponse GetListFromScreenName(string screenName) {
            return GetListFromScreenName(screenName, null);
        }

        /// <summary>
        /// Gets a list of friends for a given user using the specified options.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="options">The options for the call.</param>
        public SocialHttpResponse GetListFromScreenName(string screenName, TwitterFollowersListOptions options) {

            // Define the query string
            NameValueCollection query = new NameValueCollection {
                {"screen_name", screenName}
            };

            // Update the query string with the specified options
            if (options != null) options.UpdateNameValueCollection(query);

            // Make the call to the API
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/list.json", query);

        }

        #endregion

    }

}