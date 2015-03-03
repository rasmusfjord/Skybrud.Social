﻿using System;
using Skybrud.Social.GitHub.Objects;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Social.GitHub.Responses {

    public class GitHubOrganizationResponse : GitHubResponse<GitHubOrganization> {

        #region Constructor

        private GitHubOrganizationResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        public static GitHubOrganizationResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new GitHubOrganizationResponse(response) {
                Body = JsonObject.ParseJson(response.Body, GitHubOrganization.Parse)
            };

        }

    }

}