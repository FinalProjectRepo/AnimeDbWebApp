using System;

namespace System.Security.Claims
{
	public static class UserPrincipalExtensions
    {
		public static Guid FindFirstValueGuid(this ClaimsPrincipal principal, string claimType)
		{
			var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);
			return userId == null
				? Guid.NewGuid()
				: Guid.Parse(userId);
		}
	}
}