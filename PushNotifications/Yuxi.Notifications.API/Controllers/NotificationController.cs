using Microsoft.AspNetCore.Mvc;
using Yuxi.Notifications.Service.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yuxi.Notifications.API.Controllers
{
    public class NotificationController : Controller
    {

        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        //  Inscribir un usuario para push notifications



        //  enviar un mensaje por medio de Push notifications


    }
}
