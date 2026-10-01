using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Resolver.HelperError.IExceptions
{
    public class ApiException : Exception, IApiExceptions
    {
        #region Public Serializable properties.

        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string MessageError { get; set; }

        [DataMember]
        public string ErrorDescription { get; set; }

        [DataMember]
        public HttpStatusCode HttpStatus { get; set; }

        [DataMember]
        public string ReasonPhrase { get; set; }

        [DataMember]
        public string ReferenceLink { get; set; }
        #endregion

        #region Public Constructor.
        /// <summary>
        /// Public constructor for Api Data Exception
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorDescription"></param>
        /// <param name="httpStatus"></param>
        public ApiException(string errorCode, string errorDescription, HttpStatusCode httpStatus, string referenceLink)
        {
            ErrorCode = errorCode;
            MessageError = errorDescription;
            HttpStatus = httpStatus;
            ReferenceLink = referenceLink;
        }
        #endregion
    }
}
