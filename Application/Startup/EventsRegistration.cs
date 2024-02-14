using FamiCon.Application.Events.Listeners;
using FamiCon.Application.Events;
using Coravel.Events.Interfaces;
using Coravel;

namespace FamiCon.Application.Startup;

public static class EventsRegistration
{
    public static IServiceProvider SetupEvents(this IServiceProvider services)
    {
        IEventRegistration registration = services.ConfigureEvents();

        // add events and listeners here
        registration
            .Register<UserCreated>()
            .Subscribe<EmailNewUser>();

        return services;
    }
}
