// there are my way to create versioninng 

// first createing controllers 
    // 1) create folder      ? why ? this thing create different namespace for the system
            // v1
            // v2
    // 2) create api controller  // 


    // 3) download versioning controllers ]
        // [   aspnetcore.mvc.versioninig  ]


    // 4) add service file to the new informaiton

        // service.AddApiVersioning(); 

    // 5) Query string based versioning 
            // /api/test?api-version =1.0
            // /api/test?api-version =2.0

           // goto controller v1 then add 
           //  [ApiVersion("1.0")]


           // goto controller v2 then add 
           // [ApiVersion("2.0")]

    // 6) default api connection
        //    service.AddApiVersioning( config => 
        //         config.DefaultApiVersion = new ApiVersion(1,0);
        //         config.AssumeDefautlVersionWHenUnspacified = true;
        //    ); 



