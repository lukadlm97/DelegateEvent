﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //public delegate int WorkPreformedHendler(object sender, WorkPerformedEventArgs e);
   
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
       // public event WorkPreformedHendler WorkPerformed;
        public event EventHandler WorkCompleted;
        public void doWork(int hour,WorkType workType)
        {
            for(int i = 0;i < hour; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }
        protected virtual void OnWorkPerformed(int hour,WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del != null)
            {
                del(this,new WorkPerformedEventArgs(hour,workType));
            }
        }
        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if(del != null)
            {
                del(this,EventArgs.Empty);
            }
        }
    }
}
