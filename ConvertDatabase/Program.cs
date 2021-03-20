using ConvertDatabase.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConvertSiteAction convertSiteAction = new ConvertSiteAction();

            //int nRowConvertSite = convertSiteAction.ConvertSite();

            //Console.WriteLine(nRowConvertSite);





            //ConvertLoggerAction convertLoggerAction = new ConvertLoggerAction();

            //int nRowConvertLogger = convertLoggerAction.ConvertLogger();

            //Console.WriteLine(nRowConvertLogger);




            //ConvertChannelAction convertChannelAction = new ConvertChannelAction();

            //int nRowConvertChannel = convertChannelAction.ConvertChannel();

            //Console.WriteLine(nRowConvertChannel);


            ConvertTableLoggerAction convertTableLoggerAction = new ConvertTableLoggerAction();

            int nRowConvertDataTableLogger = convertTableLoggerAction.CovertTableLogger();

            Console.WriteLine(nRowConvertDataTableLogger);

        }

    }
}
