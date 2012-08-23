﻿using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Application.ViewModels {

    public class HomePageViewModel {

        public PaginatedDto<BlogPostDto> PaginatedBlogPostDto { get; set; }
    }
}