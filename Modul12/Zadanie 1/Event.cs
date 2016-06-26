using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie_1
{
    
    public class MyEvent
    {
        public enum STATUS { WAITING, RUNNED, ABORTED, FINISHED };
        public enum TYPE { CYCLIC, SINGLE};
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public TYPE Type { get; set; }
        public STATUS Status { get; set; }
        


        public MyEvent(int Id, string Name, DateTime StartDateTime, DateTime EndDateTime, TYPE type)
        {
            this.Id = Id;
            this.Name = Name;
            this.StartDateTime = StartDateTime;
            this.Type = type;
            this.Status = STATUS.WAITING;
        }

        public MyEvent(int Id, string Name, DateTimeOffset dateTimeOffsetToStart, DateTimeOffset dateTimeOffsetToEnd)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            do
            {
                Thread.Sleep(5000);
                Console.WriteLine(ToString());
            } while (true);
        }


        public override string ToString()
        {
            return "Name: " + Name + ", StartDateTime: " + StartDateTime + ", EndDateTime: " + EndDateTime+", STATUS: "+Status;
            //return base.ToString();
        }




    }
}
