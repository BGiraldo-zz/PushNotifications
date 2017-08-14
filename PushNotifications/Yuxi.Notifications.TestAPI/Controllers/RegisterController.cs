using Microsoft.Azure.NotificationHubs;
using Microsoft.Azure.NotificationHubs.Messaging;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Yuxi.Notifications.TestAPI.Controllers
{

    public class RegisterController : ApiController
    {

        private NotificationHubClient hub;

        public RegisterController()
        {
            var connectionString = "Endpoint=sb://pocnotifications.servicebus.windows.net/;SharedAccessKeyName=PoCNotificationPolicy;SharedAccessKey=9TqtC6BhhGIiPTd0pqblCHeJfv6VDIwk9UCO0FRQpDI=";
            var notificationHubPath = "PoCNotifications";
            hub = NotificationHubClient.CreateClientFromConnectionString(connectionString, notificationHubPath);
        }

        public class DeviceRegistration
        {
            public string Platform { get; set; }
            public string Handle { get; set; }
            public string[] Tags { get; set; }
        }

        // POST api/register
        // This creates a registration id
        public async Task<string> Post()
        {
            return await hub.CreateRegistrationIdAsync();
        }

        // PUT api/register/5
        // This creates or updates a registration (with provided PNS handle) at the specified id
        [Route ("device-register")]
        [HttpPost]
        public async void Post(string id, DeviceRegistration deviceUpdate)
        {
            // IMPORTANT: add logic to make sure that caller is allowed to register for the provided tags
            //  string[] identifiers = id.Split('&');

            RegistrationDescription registration = null;
            switch (deviceUpdate.Platform)
            // switch (identifiers[1])
            {
                case "mpns":
                    registration = new MpnsRegistrationDescription(deviceUpdate.Handle);
                    break;
                case "wns":
                    registration = new WindowsRegistrationDescription(deviceUpdate.Handle);
                    break;
                case "apns":
                    registration = new AppleRegistrationDescription(deviceUpdate.Handle);
                    break;
                case "gcm":
                    registration = new GcmRegistrationDescription(deviceUpdate.Handle);
                    // registration = new GcmRegistrationDescription(identifiers[2]);
                    break;
                default:
                    throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            registration.RegistrationId = id;
            //registration.RegistrationId = identifiers[0];
            registration.Tags = new HashSet<string>(deviceUpdate.Tags);

            try
            {
                await hub.CreateOrUpdateRegistrationAsync(registration);
            }
            catch (MessagingException e)
            {
                ReturnGoneIfHubResponseIsGone(e);
            }
        }

        // DELETE api/register/5
        public async void Delete(string id)
        {
            await hub.DeleteRegistrationAsync(id);
        }


        private static void ReturnGoneIfHubResponseIsGone(MessagingException e)
        {
            var webex = e.InnerException as WebException;
            if (webex.Status == WebExceptionStatus.ProtocolError)
            {
                var response = (HttpWebResponse)webex.Response;
                if (response.StatusCode == HttpStatusCode.Gone)
                    throw new HttpRequestException(HttpStatusCode.Gone.ToString());
            }
        }
    }

}