using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace GESICA.Authentication
{
    public class CustomAuthorizationStateProvider(ILocalStorageService localStorageService) : AuthenticationStateProvider
    {
        private ClaimsPrincipal guest = new(new ClaimsIdentity());

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                // Get local storage token if any
                string? localToken = await localStorageService.GetItemAsStringAsync("token");
                // Check if token exists to set new
                if (string.IsNullOrWhiteSpace(localToken))
                    return await Task.FromResult(new AuthenticationState(guest));

                
            } 
            catch
            {
                // Set new guest token on error
                return await Task.FromResult(new AuthenticationState(guest));
            }
        }
    }
}
