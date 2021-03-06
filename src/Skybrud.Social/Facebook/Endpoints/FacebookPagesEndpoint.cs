using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Responses.Pages;

namespace Skybrud.Social.Facebook.Endpoints {
    
    public class FacebookPagesEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookPagesRawEndpoint Raw {
            get { return Service.Client.Pages; }
        }

        #endregion

        #region Constructors

        internal FacebookPagesEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the page with the specified <code>id</code>.
        /// </summary>
        /// <param name="id">The ID of the page.</param>
        public FacebookPageResponse GetPage(string id) {
            return FacebookPageResponse.ParseResponse(Raw.GetPage(id));
        }

        #endregion

    }

}