﻿// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.ServiceModel;
using BusinessServiceContracts;

namespace BusinessServices
{

    public class ServiceA : IServiceA
    {
        public string Operation1()
        {
            return "IServiceA.Operation1() invoked.";
        }

        public string Operation2(DateTime time) //测试server参数改了，和client proxy参数不一样了，程序依旧正常运行。 page90
        {
            return "IServiceA.Operation2() invoked. time=" + time;
        }
    }

}

