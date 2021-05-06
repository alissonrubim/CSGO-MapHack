using ProjectQOTA.Helpers;
using System;
using System.Diagnostics;

namespace ProjectQOTA
{
    public class Hack
    {



        public void Start()
        {
            var process = ProcessHelper.GetByName("csgo");
            var processReaderPointer = ProcessHelper.GetReadAccess(process);
            //var memoryData = MemoryHelper.ReadFromAddress(processReaderPointer, );
        }

        public void Stop()
        {

        }
    }
}
