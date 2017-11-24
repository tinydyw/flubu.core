﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlubuCore.Tasks.Iis.Interfaces
{
    public interface ICreateWebApplicationTask : ITaskOfT<int, ICreateWebApplicationTask>
    {
        ICreateWebApplicationTask Mode(CreateWebApplicationMode mode);
            
        ICreateWebApplicationTask LocalPath(string localPath);

        /// <summary>
        /// Name of the application pool application will be controoler by.
        /// </summary>
        ICreateWebApplicationTask ApplicationPoolName(string applicationPoolName);
        
        ICreateWebApplicationTask ParentVirtualDirectoryName(string parentVirualDirectoryName);

        /// <summary>
        /// Web site name web application will be added to.
        /// </summary>
        ICreateWebApplicationTask WebsiteName(string websiteName);

        /// <summary>
        /// Mime types to be added.
        /// </summary>
        ICreateWebApplicationTask AddMimeType(params string[] mimeTypes);
    }
}
