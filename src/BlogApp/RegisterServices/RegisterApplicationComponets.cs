// ============================================
// Copyright (c) 2024. All rights reserved.
// File Name :     RegisterApplicationComponets.cs
// Company :       mpaulosky
// Author :        teqsl
// Solution Name : mpaulosky_BlogAppV3
// Project Name :  BlazorBlogs
// =============================================

namespace BlogApp.RegisterServices;
public static partial class ServiceCollectionExtensions
{
	/// <summary>
	///   Registers the application components.
	/// </summary>
	/// <param name="builder">The web application builder.</param>
	private static void RegisterApplicationComponets(this WebApplicationBuilder builder)
	{
		// Add services to the container.
		builder.Services.AddRazorComponents()
			.AddInteractiveServerComponents();
		
		builder.Services.AddDatabaseDeveloperPageExceptionFilter();
	}
}