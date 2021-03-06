﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Client
{
    /// <summary>
    /// 这里实现了对接《干部检查量化数据上传》接口的方法。只有一个CreateDataIn需要实现
    /// </summary>
    public class GanBuClient
    {
        public static APIHellper apiHelper = new APIHellper();

        public static bool Create(IEnumerable<CSMP.API.Models.train_GanBu> list)
        {
            if (null == list || list.Count() == 0)
            {
                return true;
            }

            string URL = "/Inport/CreateGanBu";
            URL = APIHellper.GetAPI(URL, null);

            var PostData = Newtonsoft.Json.JsonConvert.SerializeObject(list);

            var retrunData = apiHelper.PostHttpData(URL, PostData);
            var result = apiHelper.APIJsonDeserializeA<string>(retrunData);
            Console.WriteLine(result.ErrorCode);
            Console.WriteLine(result.ErrorMsg);
            return result.ErrorCode == 0;

        }

    }
}
