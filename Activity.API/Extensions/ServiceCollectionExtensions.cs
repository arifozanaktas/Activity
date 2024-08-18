﻿using FluentValidation.AspNetCore;
using FluentValidation;
using Activity.Dto.Activity;
using Activity.Dto;
using Activity.Validations.Validators;
using Activity.Dto.Product;
using Activity.Validations.Validators.Product;

namespace Activity.API.Extensions
{
    public static class ServiceCollectionExtensions
    {


        public static IServiceCollection AddValidations(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<CreateCategoryRequestDto>, CreateCategoryRequestValidation>();
            services.AddScoped<IValidator<CreateActivityRequestDto>, CreateActivityRequestValidation>();
            services.AddScoped<IValidator<UpdateActivityRequestDto>, UpdateActivityRequestValidation>();
            services.AddScoped<IValidator<CreateBlogRequestDto>, CreateBlogRequestValidation>();
            services.AddScoped<IValidator<CreateProductRequestDto>, CreateProductRequestValidation>();
            services.AddScoped<IValidator<UpdateProductRequestDto>, UpdateProductRequestValidation>();
            return services;
        }
    }
}
