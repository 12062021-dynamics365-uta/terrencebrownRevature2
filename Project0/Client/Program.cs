using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Serilog;
using Serilog.Core;
using Models;
using Domain;




namespace Client



{

    class Program
    {
        static void Main(string[] args)
        {


            Mapping myMapping = new Mapping();
            Selection mySel = new Selection();
            Storage.DataBase myDB = new Storage.DataBase(myMapping);
            List<Models.Store> ms1 = new List<Models.Store>();


            //Log file was created to monitor code and error issues  
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Users\Terrence\Desktop\Project0\Logging\LogFile.log").CreateLogger();
            Log.Information("This is the log information for Project0 )");


            Selection mySelectionToStartProgram = new Selection();
            //mySelectionToStartProgram.CurrentUser();
            mySelectionToStartProgram.userSelectionNumber();



    

              






            

    









                }
        }
            
} 