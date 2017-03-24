﻿using System.Net;
using System.Security;

namespace ZangAPI.Configuration
{
    /// <summary>
    /// Zang configuration
    /// </summary>
    /// <seealso cref="ZangAPI.Configuration.IZangConfiguration" />
    public class ZangConfiguration : IZangConfiguration
    {
        /// <summary>
        /// Gets the account sid.
        /// </summary>
        /// <value>
        /// The account sid.
        /// </value>
        public string AccountSid { get; set; }

        /// <summary>
        /// Gets or sets the secure authentication token.
        /// </summary>
        /// <value>
        /// The secure authentication token.
        /// </value>
        private SecureString SecureAuthToken { get; set; }

        /// <summary>
        /// Gets the authentication token.
        /// </summary>
        /// <value>
        /// The authentication token.
        /// </value>
        public string AuthToken
        {
            get { return new NetworkCredential(string.Empty, SecureAuthToken).Password; }
            set { SecureAuthToken = new NetworkCredential(string.Empty, value).SecurePassword; }
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets the proxy host.
        /// </summary>
        /// <value>
        /// The proxy host.
        /// </value>
        public string ProxyHost { get; set; }

        /// <summary>
        /// Gets the proxy port.
        /// </summary>
        /// <value>
        /// The proxy port.
        /// </value>
        public string ProxyPort { get; set; }

        /// <summary>
        /// Gets a value indicating whether [use proxy].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use proxy]; otherwise, <c>false</c>.
        /// </value>
        public bool UseProxy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZangConfiguration"/> class.
        /// </summary>
        public ZangConfiguration()
        {
            this.BaseUrl = "https://api.zang.io/v2";
            this.ProxyHost = "";
            this.ProxyPort = "";
            this.UseProxy = false;
        }
    }
}