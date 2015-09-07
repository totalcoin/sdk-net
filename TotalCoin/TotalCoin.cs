using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace TotalCoin
{
	public class TotalCoin
	{

		#region Private fields

        private const string AuthorizeEndpoint = "https://api.totalcoin.com/ar-test/Security/";
        private const string CheckoutEndpoint = "https://api.totalcoin.com/ar-test/Checkout/";
        private const string MerchantEndpoint = "https://api.totalcoin.com/ar-test/Merchant/";
        private const string IpnEndpoint = "https://api.totalcoin.com/ar-test/Ipn/";

		private string _givenToken;
        private UserCredentials userCredentials;

		#endregion

		#region Public methods

        public TotalCoin(string email, Guid apiKey)
        {
            userCredentials = new UserCredentials(email, apiKey);
        }

		/// <summary>
		/// Authorizes the specified user credentials.
		/// </summary>
		/// <param name="userCredentials">The user credentials.</param>
		/// <returns>AuthorizeResponse with the username and given token</returns>
		public ApiResponse<AuthorizeResponse> GetAccessToken()
		{
			try
			    {
				if (userCredentials == null || string.IsNullOrEmpty(userCredentials.Email) || userCredentials.ApiKey == null)
                    return new ApiResponse<AuthorizeResponse>(false, "Email y apiKey son parametros requeridos", null);

				var result = CallToApi<ApiResponse<AuthorizeResponse>, UserCredentials>(AuthorizeEndpoint, "POST", userCredentials);

				if (result == null)
                    return new ApiResponse<AuthorizeResponse>(false, "Error al conectar con la API", null);

				_givenToken = result.Response.TokenId.ToString();
                return result;

			}
			catch (Exception e)
			{
                return new ApiResponse<AuthorizeResponse>(false, e.Message, null);
			}

		}

		/// <summary>
		/// Checkouts the specified purchase information.
		/// </summary>
		/// <param name="purchaseInformation">The purchase information.</param>
		/// <returns>CheckoutResponse containing the URL</returns>
        public ApiResponse<CheckoutResponse> PerformCheckout(PurchaseInformation purchaseInformation)
		{
			try
			{
				if (purchaseInformation == null)
                    return new ApiResponse<CheckoutResponse>(false, "PurchaseInformation es un parametro requerido", null);

                GetAccessToken();

				if(_givenToken == null)
                    return new ApiResponse<CheckoutResponse>(false, "Usuario invalido.", null);

                string endpointURL = string.Format(CheckoutEndpoint + "{0}/", _givenToken);

                var result = CallToApi <ApiResponse<CheckoutResponse>, PurchaseInformation>(endpointURL, "POST", purchaseInformation);

				if (result == null)
                    return new ApiResponse<CheckoutResponse>(false, "Error al conectar con la API", null);

                return result;
			}
			catch (Exception e)
			{
                return new ApiResponse<CheckoutResponse>(false, e.Message, null);
			}
		}

        /// <summary>
        /// Gets the merchants for the specified user token.
        /// </summary>
        /// <returns>MerchantResponse object</returns>
        public ApiResponse<List<MerchantResponse>> GetMerchants()
        {
            try
            {
                GetAccessToken();

                if (_givenToken == null)
                    return new ApiResponse<List<MerchantResponse>>(false, "Usuario invalido.", null);

                string endpointURL = string.Format(MerchantEndpoint + "{0}/", _givenToken);

                var result = CallToApi <ApiResponse<List<MerchantResponse>>>(endpointURL, "GET");

                if (result == null)
                    return new ApiResponse<List<MerchantResponse>>(false, "Error al conectar con la API", null);

                return result;
            }
            catch (Exception e)
            {
                return new ApiResponse<List<MerchantResponse>>(false, e.Message, null);
            }
        }

        /// <summary>
        /// Gets the merchants for the specified user token.
        /// </summary>
        /// <returns>MerchantResponse object</returns>
        public ApiResponse<IpnResponse> GetIpnInfo(string referenceId)
        {
            try
            {
                GetAccessToken();

                if (_givenToken == null)
                    return new ApiResponse<IpnResponse>(false, "Usuario invalido.", null);

                string endpointURL = string.Format(IpnEndpoint + "{0}/{1}", userCredentials.ApiKey, referenceId);

                var result = CallToApi<ApiResponse<IpnResponse>>(endpointURL, "GET");

                if (result == null)
                    return new ApiResponse<IpnResponse>(false, "Error al conectar con la API", null);

                return result;
            }
            catch (Exception e)
            {
                return new ApiResponse<IpnResponse>(false, e.Message, null);
            }
        }

		#endregion

		#region Private Methods

        private T CallToApi<T>(string url, string httpMethod) where T : class
        {
            return CallToApi<T, Object>(url, httpMethod, null);
        }

		private T CallToApi<T, T2>(string url, string httpMethod, T2 parameters) where T : class
		{


            MemoryStream mem;
            string jsonData = string.Empty;
            DataContractJsonSerializer ser;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = httpMethod;

            if (parameters != null)
            {
                ser = new DataContractJsonSerializer(typeof(T2));
                mem = new MemoryStream();
                ser.WriteObject(mem, parameters);
                jsonData = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonData);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

            HttpWebResponse resp = (HttpWebResponse)httpWebRequest.GetResponse();
            ser = new DataContractJsonSerializer(typeof(T));
            return ser.ReadObject(resp.GetResponseStream()) as T;
		}

		#endregion
	}
}
