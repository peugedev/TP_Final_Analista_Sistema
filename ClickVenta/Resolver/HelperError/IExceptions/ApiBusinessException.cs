using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Resolver.HelperError.IExceptions
{
    public class ApiBusinessException : Exception, IApiExceptions
    {

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

        #region Public Constructor.
        /// <summary>
        /// Public constructor for Api Business Exception
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorDescription"></param>
        /// <param name="httpStatus"></param>
        public ApiBusinessException(string errorCode, string errorDescription, HttpStatusCode httpStatus, string referenceLink)
        {
            ErrorCode = errorCode;
            MessageError = errorDescription;
            HttpStatus = httpStatus;
            ReferenceLink = referenceLink;
        }

        #endregion
    }
}
