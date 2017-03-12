using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSMP.API.Models;
using API.Client;

namespace DemoStart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<train_DataIn> list = new List<train_DataIn>();
            for (int i = 0; i < 10; i++)
            {
                train_DataIn info = new train_DataIn();

                ///检查时间
                info.f_CheckDate = DateTime.Now;
                ///检查类别
                info.f_CheckType = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///检查人部门
                info.f_CheckUserDepartment = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///检查人
                info.f_CheckUserName = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///检查人职务
                info.f_CheckUserPostion = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///两违内容
                info.f_Detail = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///是否动态
                info.f_DongTai = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///问题代码
                info.f_QuestionCode = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///定性定责
                info.f_QuestionLever = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///主要责任人
                info.f_QuestionMainUser = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///相关责任人
                info.f_QuestionMainUserOther = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///职务
                info.f_QuestionMainUserPosition = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///提交时间
                info.f_SubmitDate = DateTime.Now;
                info.f_TrainName = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///导入日期
                info.f_UploadDate = DateTime.Now;
                ///调用接口时的日期.ToString("yyyyMMddHHmmss")
                info.f_UploadDateGroup = i + "_" + DateTime.Now.ToFileTime().ToString();
                ///预留字段，可保留0或将你方主键赋上去
                info.f_UploadID = 1;
                //info.f_ID = 0;

                list.Add(info);
            }
            var result = DataInClient.Create(list);
            Console.WriteLine("随机生成了10条记录。并一起Create到api里去。结果是：" + result);
            Console.ReadLine();
        }
    }
}
