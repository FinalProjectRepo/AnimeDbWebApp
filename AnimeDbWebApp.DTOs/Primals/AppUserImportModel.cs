﻿using Microsoft.AspNetCore.Identity;
using System;

namespace AnimeDbWebApp.DTOs.Primals
{
	public class AppUserImportModel
	{
		public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string NormalizedUserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string NormalizedEmail { get; set; } = null!;
        public bool EmailConfirmed { get; set; }
		public string PasswordHash { get; set; } = null!;
		public string SecurityStamp { get; set; } = null!;
		public string ConcurrencyStamp { get; set; } = null!;
		public string? PhoneNumber { get; set; }
		public bool PhoneNumberConfirmed { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public DateTimeOffset? LockoutEnd { get; set; }
		public bool LockoutEnabled { get; set; }
		public int AccessFailedCount { get; set; }
	}
}